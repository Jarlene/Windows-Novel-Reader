﻿using Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace NovelReader
{
    class BackgroundService
    {

        private static BackgroundService instance;
        private Thread workerThread;
        private Thread scheduleTTSThread;
        private Thread updateThread;
        private System.Timers.Timer updateTimer;
        public Scheduler ttsScheduler;

        private volatile bool shutDown;
        private volatile bool hasTTSShutDown;
        private volatile bool hasUpdateShutDown;

        public volatile TTSController ttsController;
        public volatile NovelListController novelListController;
        public volatile NovelReaderForm novelReaderForm;

        /*============Properties============*/

        public static BackgroundService Instance
        {
            get
            {
                if (instance == null)
                {
                    Console.WriteLine("Create instance of PlayListScheduler");
                    instance = new BackgroundService();
                }
                return instance;
            }
        }


        /*============Constructor===========*/

        private BackgroundService()
        {
            Console.WriteLine("Backgroundservice Constructor");
        }

        public void StartService()
        {
            this.shutDown = false;
            this.hasTTSShutDown = true;
            this.hasUpdateShutDown = true;
            this.updateThread = new Thread(Update);
            this.workerThread = new Thread(DoWork);
            this.ttsScheduler = new Scheduler(Configuration.Instance.TTSThreadCount);
            this.ttsScheduler.ttsProgressEventHandler += TTSProgress;
            this.updateTimer = new System.Timers.Timer(Configuration.Instance.UpdateInterval);
            this.updateTimer.Enabled = true;
            this.updateTimer.Elapsed += new ElapsedEventHandler(OnUpdateTimer);
            
            this.scheduleTTSThread = new Thread(ScheduleTTS);
            //this.updateTimer.Interval = Configuration.Instance.UpdateInterval;
            
            this.updateTimer.Start();
            this.scheduleTTSThread.Start();
            this.workerThread.Start();
            this.ttsScheduler.StartTTSService();
            this.updateThread.Start();
        }

        public void CloseService()
        {
            //this.scheduleTTSThread.
            this.shutDown = true;
            this.updateTimer.Stop();
            this.updateTimer = null;
            this.workerThread = null;
            //this.scheduleTTSThread = null;
            this.ttsScheduler.ShutdownService();
            while (!hasTTSShutDown || !hasUpdateShutDown)
            {

            }
        }

        /*============Getter/Setter=========*/
        /*============EventHandler==========*/

        private void OnUpdateTimer(Object source, ElapsedEventArgs e)
        {
            if (!updateThread.IsAlive)
            {
                updateThread = new Thread(Update);
                updateThread.Start();
            }
        }

        private void TTSProgress(Object sender, TTSProgressEventArgs e)
        {
            //Console.WriteLine(e.request.ChapterTitle + " complete.");
            NovelLibrary.Instance.GetNovel(e.request.Chapter.NovelTitle).FinishRequest(e.request.Chapter);
        }

        /*============Public Function=======*/

        public Tuple<bool, string> AddNovel(string novelTitle, NovelSource novelSource)
        {
            return NovelLibrary.Instance.AddNovel(novelTitle, novelSource);
        }

        public void DeleteNovel(string novelTitle, bool deleteData)
        {
            NovelLibrary.Instance.DeleteNovel(novelTitle, deleteData);
        }

        public bool RankUpNovel(string novelTitle)
        {
            return NovelLibrary.Instance.RankUpNovel(novelTitle);
        }

        public bool RankDownNovel(string novelTitle)
        {
            return NovelLibrary.Instance.RankDownNovel(novelTitle);
        }

        public void UpdateTTSTest()
        {
            if (!updateThread.IsAlive)
            {
                updateThread = new Thread(Update);
                updateThread.Start();
            }
        }

        public void UpdateTimerInterval(int minutes)
        {
            int ms = minutes * 60000; //60000ms per min
            Configuration.Instance.UpdateInterval = ms;
            updateTimer.Interval = ms;
            this.updateTimer.Start();
            Console.WriteLine(ms);
        }

        public void ResetTTSList()
        {
            ttsScheduler.ClearRequests();
            foreach (Novel n in NovelLibrary.Instance.NovelList)
            {
                n.ResetTTSRequest();
            }
        }

        /*============Private Function======*/

        private void DoWork()
        {
            /*
            while (!shutDown)
            {
                Thread.Sleep(1000);
            }
             * */
        }

        private void Update()
        {
            hasUpdateShutDown = false;
            CheckUpdates();
            DownloadUpdates();
            NovelLibrary.Instance.SaveNovelLibrary();
            hasUpdateShutDown = true;
        }

        private void ScheduleTTS()
        {
            hasTTSShutDown = false;
            int roundRobin = 0;
            Dictionary<string, int> position = new Dictionary<string, int>();
            int idleCounter = 0;
            while (!shutDown)
            {
                if (ttsScheduler.Threads > 0 && NovelLibrary.Instance.GetNovelCount() > 0)
                {
                    Novel n = NovelLibrary.Instance.NovelList[roundRobin % NovelLibrary.Instance.GetNovelCount()];
                    roundRobin++;
                    Request request = n.GetTTSRequest(Configuration.Instance.TTSSpeed);
                    if (request == null)
                    {
                        //If no new chapter to synthesize, then sleep for 10 seconds before checking.
                        idleCounter++;
                        if (idleCounter >= NovelLibrary.Instance.GetNovelCount())
                        {
                            Console.WriteLine("Idling TTS");
                            Thread.Sleep(10000);
                        }
                        continue;
                    }
                    ttsScheduler.AddRequest(request);
                    idleCounter = 0;
                    Thread.Sleep(1000 * ttsScheduler.RequestCount / ttsScheduler.Threads);
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }
            hasTTSShutDown = true;
        }

        private void CheckUpdates()
        {
            Novel[] updateNovels = NovelLibrary.Instance.GetUpdatingNovel();
            for (int i = 0; i < updateNovels.Length && !shutDown; i++)
            {
                if (updateNovels[i] == null)
                    continue;
                updateNovels[i].CheckForUpdate();
                NovelLibrary.Instance.db.Store(updateNovels[i]);
            }
            NovelLibrary.Instance.db.Commit();
            Configuration.Instance.LastFullUpdateTime = DateTime.Now;
        }

        private void DownloadUpdates()
        {
            Novel[] updateNovels = NovelLibrary.Instance.GetUpdatingNovel();
            for (int i = 0; i < updateNovels.Length && !shutDown; i++)
            {
                if (updateNovels[i] == null)
                    continue;
                updateNovels[i].LoadChapterFromDB();
                int updateCount = updateNovels[i].GetUpdateCount();
                int idx = 0;
                int lastUpdatedIdx = 0;
                while(updateNovels[i] != null && updateNovels[i].HasUpdate() && !shutDown){
                    idx++;
                    lastUpdatedIdx = updateNovels[i].DownloadNextUpdate(lastUpdatedIdx, idx, updateCount);
                }
                if (updateNovels[i] == null)
                    continue;
                updateNovels[i].NewChaptersNotReadCount = updateNovels[i].NewChaptersNotReadCount + idx;
                updateNovels[i].SetUpdateProgress(0, 0, Novel.UpdateStates.UpToDate);
                updateNovels[i].ClearChapters();
            }
            NovelLibrary.Instance.db.Commit();
        }


    }
}
