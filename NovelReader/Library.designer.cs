﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NovelReader
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	public partial class LibraryDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertNovel(Novel instance);
    partial void UpdateNovel(Novel instance);
    partial void DeleteNovel(Novel instance);
    partial void InsertChapter(Chapter instance);
    partial void UpdateChapter(Chapter instance);
    partial void DeleteChapter(Chapter instance);
    partial void InsertChapterUrl(ChapterUrl instance);
    partial void UpdateChapterUrl(ChapterUrl instance);
    partial void DeleteChapterUrl(ChapterUrl instance);
    partial void InsertSource(Source instance);
    partial void UpdateSource(Source instance);
    partial void DeleteSource(Source instance);
    #endregion
		
		public LibraryDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Novel> Novels
		{
			get
			{
				return this.GetTable<Novel>();
			}
		}
		
		public System.Data.Linq.Table<Chapter> Chapters
		{
			get
			{
				return this.GetTable<Chapter>();
			}
		}
		
		public System.Data.Linq.Table<ChapterUrl> ChapterUrls
		{
			get
			{
				return this.GetTable<ChapterUrl>();
			}
		}
		
		public System.Data.Linq.Table<Source> Sources
		{
			get
			{
				return this.GetTable<Source>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Novel : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _NovelTitle;
		
		private int _Rank;
		
		private int _StateID;
		
		private System.Nullable<int> _LastReadChapterID;
		
		private int _ChaptersNotReadCount;
		
		private bool _MakeAudio;
		
		private EntitySet<Chapter> _Chapters;
		
		private EntitySet<Source> _Sources;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNovelTitleChanging(string value);
    partial void OnNovelTitleChanged();
    partial void OnRankChanging(int value);
    partial void OnRankChanged();
    partial void OnStateIDChanging(int value);
    partial void OnStateIDChanged();
    partial void OnLastReadChapterIDChanging(System.Nullable<int> value);
    partial void OnLastReadChapterIDChanged();
    partial void OnChaptersNotReadCountChanging(int value);
    partial void OnChaptersNotReadCountChanged();
    partial void OnMakeAudioChanging(bool value);
    partial void OnMakeAudioChanged();
    #endregion
		
		public Novel()
		{
			this._Chapters = new EntitySet<Chapter>(new Action<Chapter>(this.attach_Chapters), new Action<Chapter>(this.detach_Chapters));
			this._Sources = new EntitySet<Source>(new Action<Source>(this.attach_Sources), new Action<Source>(this.detach_Sources));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NovelTitle", CanBeNull=false, IsPrimaryKey=true)]
		public string NovelTitle
		{
			get
			{
				return this._NovelTitle;
			}
			set
			{
				if ((this._NovelTitle != value))
				{
					this.OnNovelTitleChanging(value);
					this.SendPropertyChanging();
					this._NovelTitle = value;
					this.SendPropertyChanged("NovelTitle");
					this.OnNovelTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rank")]
		public int Rank
		{
			get
			{
				return this._Rank;
			}
			set
			{
				if ((this._Rank != value))
				{
					this.OnRankChanging(value);
					this.SendPropertyChanging();
					this._Rank = value;
					this.SendPropertyChanged("Rank");
					this.OnRankChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateID")]
		public int StateID
		{
			get
			{
				return this._StateID;
			}
			set
			{
				if ((this._StateID != value))
				{
					this.OnStateIDChanging(value);
					this.SendPropertyChanging();
					this._StateID = value;
					this.SendPropertyChanged("StateID");
					this.OnStateIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastReadChapterID")]
		public System.Nullable<int> LastReadChapterID
		{
			get
			{
				return this._LastReadChapterID;
			}
			set
			{
				if ((this._LastReadChapterID != value))
				{
					this.OnLastReadChapterIDChanging(value);
					this.SendPropertyChanging();
					this._LastReadChapterID = value;
					this.SendPropertyChanged("LastReadChapterID");
					this.OnLastReadChapterIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChaptersNotReadCount")]
		public int ChaptersNotReadCount
		{
			get
			{
				return this._ChaptersNotReadCount;
			}
			set
			{
				if ((this._ChaptersNotReadCount != value))
				{
					this.OnChaptersNotReadCountChanging(value);
					this.SendPropertyChanging();
					this._ChaptersNotReadCount = value;
					this.SendPropertyChanged("ChaptersNotReadCount");
					this.OnChaptersNotReadCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MakeAudio")]
		public bool MakeAudio
		{
			get
			{
				return this._MakeAudio;
			}
			set
			{
				if ((this._MakeAudio != value))
				{
					this.OnMakeAudioChanging(value);
					this.SendPropertyChanging();
					this._MakeAudio = value;
					this.SendPropertyChanged("MakeAudio");
					this.OnMakeAudioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Novel_Chapter", Storage="_Chapters", ThisKey="NovelTitle", OtherKey="NovelTitle")]
		public EntitySet<Chapter> Chapters
		{
			get
			{
				return this._Chapters;
			}
			set
			{
				this._Chapters.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Novel_Source", Storage="_Sources", ThisKey="NovelTitle", OtherKey="NovelTitle")]
		public EntitySet<Source> Sources
		{
			get
			{
				return this._Sources;
			}
			set
			{
				this._Sources.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Chapters(Chapter entity)
		{
			this.SendPropertyChanging();
			entity.Novel = this;
		}
		
		private void detach_Chapters(Chapter entity)
		{
			this.SendPropertyChanging();
			entity.Novel = null;
		}
		
		private void attach_Sources(Source entity)
		{
			this.SendPropertyChanging();
			entity.Novel = this;
		}
		
		private void detach_Sources(Source entity)
		{
			this.SendPropertyChanging();
			entity.Novel = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Chapter : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _NovelTitle;
		
		private string _ChapterTitle;
		
		private int _Index;
		
		private bool _Read;
		
		private string _HashID;
		
		private EntitySet<ChapterUrl> _ChapterUrls;
		
		private EntityRef<Novel> _Novel;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNovelTitleChanging(string value);
    partial void OnNovelTitleChanged();
    partial void OnChapterTitleChanging(string value);
    partial void OnChapterTitleChanged();
    partial void OnIndexChanging(int value);
    partial void OnIndexChanged();
    partial void OnReadChanging(bool value);
    partial void OnReadChanged();
    partial void OnHashIDChanging(string value);
    partial void OnHashIDChanged();
    #endregion
		
		public Chapter()
		{
			this._ChapterUrls = new EntitySet<ChapterUrl>(new Action<ChapterUrl>(this.attach_ChapterUrls), new Action<ChapterUrl>(this.detach_ChapterUrls));
			this._Novel = default(EntityRef<Novel>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NovelTitle", CanBeNull=false)]
		public string NovelTitle
		{
			get
			{
				return this._NovelTitle;
			}
			set
			{
				if ((this._NovelTitle != value))
				{
					if (this._Novel.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNovelTitleChanging(value);
					this.SendPropertyChanging();
					this._NovelTitle = value;
					this.SendPropertyChanged("NovelTitle");
					this.OnNovelTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChapterTitle", CanBeNull=false)]
		public string ChapterTitle
		{
			get
			{
				return this._ChapterTitle;
			}
			set
			{
				if ((this._ChapterTitle != value))
				{
					this.OnChapterTitleChanging(value);
					this.SendPropertyChanging();
					this._ChapterTitle = value;
					this.SendPropertyChanged("ChapterTitle");
					this.OnChapterTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Index")]
		public int Index
		{
			get
			{
				return this._Index;
			}
			set
			{
				if ((this._Index != value))
				{
					this.OnIndexChanging(value);
					this.SendPropertyChanging();
					this._Index = value;
					this.SendPropertyChanged("Index");
					this.OnIndexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Read")]
		public bool Read
		{
			get
			{
				return this._Read;
			}
			set
			{
				if ((this._Read != value))
				{
					this.OnReadChanging(value);
					this.SendPropertyChanging();
					this._Read = value;
					this.SendPropertyChanged("Read");
					this.OnReadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HashID", CanBeNull=false)]
		public string HashID
		{
			get
			{
				return this._HashID;
			}
			set
			{
				if ((this._HashID != value))
				{
					this.OnHashIDChanging(value);
					this.SendPropertyChanging();
					this._HashID = value;
					this.SendPropertyChanged("HashID");
					this.OnHashIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Chapter_ChapterUrl", Storage="_ChapterUrls", ThisKey="ID", OtherKey="ChapterID")]
		public EntitySet<ChapterUrl> ChapterUrls
		{
			get
			{
				return this._ChapterUrls;
			}
			set
			{
				this._ChapterUrls.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Novel_Chapter", Storage="_Novel", ThisKey="NovelTitle", OtherKey="NovelTitle", IsForeignKey=true)]
		public Novel Novel
		{
			get
			{
				return this._Novel.Entity;
			}
			set
			{
				Novel previousValue = this._Novel.Entity;
				if (((previousValue != value) 
							|| (this._Novel.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Novel.Entity = null;
						previousValue.Chapters.Remove(this);
					}
					this._Novel.Entity = value;
					if ((value != null))
					{
						value.Chapters.Add(this);
						this._NovelTitle = value.NovelTitle;
					}
					else
					{
						this._NovelTitle = default(string);
					}
					this.SendPropertyChanged("Novel");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ChapterUrls(ChapterUrl entity)
		{
			this.SendPropertyChanging();
			entity.Chapter = this;
		}
		
		private void detach_ChapterUrls(ChapterUrl entity)
		{
			this.SendPropertyChanging();
			entity.Chapter = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class ChapterUrl : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Url;
		
		private bool _Valid;
		
		private int _ChapterID;
		
		private int _SourceID;
		
		private bool _Vip;
		
		private int _Hash;
		
		private EntityRef<Source> _Source;
		
		private EntityRef<Chapter> _Chapter;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    partial void OnValidChanging(bool value);
    partial void OnValidChanged();
    partial void OnChapterIDChanging(int value);
    partial void OnChapterIDChanged();
    partial void OnSourceIDChanging(int value);
    partial void OnSourceIDChanged();
    partial void OnVipChanging(bool value);
    partial void OnVipChanged();
    partial void OnHashChanging(int value);
    partial void OnHashChanged();
    #endregion
		
		public ChapterUrl()
		{
			this._Source = default(EntityRef<Source>);
			this._Chapter = default(EntityRef<Chapter>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", CanBeNull=false, IsPrimaryKey=true)]
		public string Url
		{
			get
			{
				return this._Url;
			}
			set
			{
				if ((this._Url != value))
				{
					this.OnUrlChanging(value);
					this.SendPropertyChanging();
					this._Url = value;
					this.SendPropertyChanged("Url");
					this.OnUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Valid")]
		public bool Valid
		{
			get
			{
				return this._Valid;
			}
			set
			{
				if ((this._Valid != value))
				{
					this.OnValidChanging(value);
					this.SendPropertyChanging();
					this._Valid = value;
					this.SendPropertyChanged("Valid");
					this.OnValidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChapterID")]
		public int ChapterID
		{
			get
			{
				return this._ChapterID;
			}
			set
			{
				if ((this._ChapterID != value))
				{
					if (this._Chapter.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnChapterIDChanging(value);
					this.SendPropertyChanging();
					this._ChapterID = value;
					this.SendPropertyChanged("ChapterID");
					this.OnChapterIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SourceID")]
		public int SourceID
		{
			get
			{
				return this._SourceID;
			}
			set
			{
				if ((this._SourceID != value))
				{
					if (this._Source.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSourceIDChanging(value);
					this.SendPropertyChanging();
					this._SourceID = value;
					this.SendPropertyChanged("SourceID");
					this.OnSourceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vip")]
		public bool Vip
		{
			get
			{
				return this._Vip;
			}
			set
			{
				if ((this._Vip != value))
				{
					this.OnVipChanging(value);
					this.SendPropertyChanging();
					this._Vip = value;
					this.SendPropertyChanged("Vip");
					this.OnVipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hash")]
		public int Hash
		{
			get
			{
				return this._Hash;
			}
			set
			{
				if ((this._Hash != value))
				{
					this.OnHashChanging(value);
					this.SendPropertyChanging();
					this._Hash = value;
					this.SendPropertyChanged("Hash");
					this.OnHashChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Source_ChapterUrl", Storage="_Source", ThisKey="SourceID", OtherKey="ID", IsForeignKey=true)]
		public Source Source
		{
			get
			{
				return this._Source.Entity;
			}
			set
			{
				Source previousValue = this._Source.Entity;
				if (((previousValue != value) 
							|| (this._Source.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Source.Entity = null;
						previousValue.ChapterUrls.Remove(this);
					}
					this._Source.Entity = value;
					if ((value != null))
					{
						value.ChapterUrls.Add(this);
						this._SourceID = value.ID;
					}
					else
					{
						this._SourceID = default(int);
					}
					this.SendPropertyChanged("Source");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Chapter_ChapterUrl", Storage="_Chapter", ThisKey="ChapterID", OtherKey="ID", IsForeignKey=true)]
		public Chapter Chapter
		{
			get
			{
				return this._Chapter.Entity;
			}
			set
			{
				Chapter previousValue = this._Chapter.Entity;
				if (((previousValue != value) 
							|| (this._Chapter.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Chapter.Entity = null;
						previousValue.ChapterUrls.Remove(this);
					}
					this._Chapter.Entity = value;
					if ((value != null))
					{
						value.ChapterUrls.Add(this);
						this._ChapterID = value.ID;
					}
					else
					{
						this._ChapterID = default(int);
					}
					this.SendPropertyChanged("Chapter");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Source : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _SourceNovelLocation;
		
		private string _SourceNovelID;
		
		private string _NovelTitle;
		
		private bool _Mirror;
		
		private int _Priority;
		
		private bool _Valid;
		
		private EntitySet<ChapterUrl> _ChapterUrls;
		
		private EntityRef<Novel> _Novel;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnSourceNovelLocationChanging(string value);
    partial void OnSourceNovelLocationChanged();
    partial void OnSourceNovelIDChanging(string value);
    partial void OnSourceNovelIDChanged();
    partial void OnNovelTitleChanging(string value);
    partial void OnNovelTitleChanged();
    partial void OnMirrorChanging(bool value);
    partial void OnMirrorChanged();
    partial void OnPriorityChanging(int value);
    partial void OnPriorityChanged();
    partial void OnValidChanging(bool value);
    partial void OnValidChanged();
    #endregion
		
		public Source()
		{
			this._ChapterUrls = new EntitySet<ChapterUrl>(new Action<ChapterUrl>(this.attach_ChapterUrls), new Action<ChapterUrl>(this.detach_ChapterUrls));
			this._Novel = default(EntityRef<Novel>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SourceNovelLocation", CanBeNull=false)]
		public string SourceNovelLocation
		{
			get
			{
				return this._SourceNovelLocation;
			}
			set
			{
				if ((this._SourceNovelLocation != value))
				{
					this.OnSourceNovelLocationChanging(value);
					this.SendPropertyChanging();
					this._SourceNovelLocation = value;
					this.SendPropertyChanged("SourceNovelLocation");
					this.OnSourceNovelLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SourceNovelID", CanBeNull=false)]
		public string SourceNovelID
		{
			get
			{
				return this._SourceNovelID;
			}
			set
			{
				if ((this._SourceNovelID != value))
				{
					this.OnSourceNovelIDChanging(value);
					this.SendPropertyChanging();
					this._SourceNovelID = value;
					this.SendPropertyChanged("SourceNovelID");
					this.OnSourceNovelIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NovelTitle", CanBeNull=false)]
		public string NovelTitle
		{
			get
			{
				return this._NovelTitle;
			}
			set
			{
				if ((this._NovelTitle != value))
				{
					if (this._Novel.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNovelTitleChanging(value);
					this.SendPropertyChanging();
					this._NovelTitle = value;
					this.SendPropertyChanged("NovelTitle");
					this.OnNovelTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mirror")]
		public bool Mirror
		{
			get
			{
				return this._Mirror;
			}
			set
			{
				if ((this._Mirror != value))
				{
					this.OnMirrorChanging(value);
					this.SendPropertyChanging();
					this._Mirror = value;
					this.SendPropertyChanged("Mirror");
					this.OnMirrorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Priority")]
		public int Priority
		{
			get
			{
				return this._Priority;
			}
			set
			{
				if ((this._Priority != value))
				{
					this.OnPriorityChanging(value);
					this.SendPropertyChanging();
					this._Priority = value;
					this.SendPropertyChanged("Priority");
					this.OnPriorityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Valid")]
		public bool Valid
		{
			get
			{
				return this._Valid;
			}
			set
			{
				if ((this._Valid != value))
				{
					this.OnValidChanging(value);
					this.SendPropertyChanging();
					this._Valid = value;
					this.SendPropertyChanged("Valid");
					this.OnValidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Source_ChapterUrl", Storage="_ChapterUrls", ThisKey="ID", OtherKey="SourceID")]
		public EntitySet<ChapterUrl> ChapterUrls
		{
			get
			{
				return this._ChapterUrls;
			}
			set
			{
				this._ChapterUrls.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Novel_Source", Storage="_Novel", ThisKey="NovelTitle", OtherKey="NovelTitle", IsForeignKey=true)]
		public Novel Novel
		{
			get
			{
				return this._Novel.Entity;
			}
			set
			{
				Novel previousValue = this._Novel.Entity;
				if (((previousValue != value) 
							|| (this._Novel.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Novel.Entity = null;
						previousValue.Sources.Remove(this);
					}
					this._Novel.Entity = value;
					if ((value != null))
					{
						value.Sources.Add(this);
						this._NovelTitle = value.NovelTitle;
					}
					else
					{
						this._NovelTitle = default(string);
					}
					this.SendPropertyChanged("Novel");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ChapterUrls(ChapterUrl entity)
		{
			this.SendPropertyChanging();
			entity.Source = this;
		}
		
		private void detach_ChapterUrls(ChapterUrl entity)
		{
			this.SendPropertyChanging();
			entity.Source = null;
		}
	}
}
#pragma warning restore 1591
