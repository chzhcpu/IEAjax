﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace IEAjax
{
    #region 上下文
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    public partial class patentEntities : ObjectContext
    {
        #region 构造函数
    
        /// <summary>
        /// 请使用应用程序配置文件的“patentEntities”部分中的连接字符串初始化新 patentEntities 对象。
        /// </summary>
        public patentEntities() : base("name=patentEntities", "patentEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 patentEntities 对象。
        /// </summary>
        public patentEntities(string connectionString) : base(connectionString, "patentEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 patentEntities 对象。
        /// </summary>
        public patentEntities(EntityConnection connection) : base(connection, "patentEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 分部方法
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<epo_biblio> epo_biblio
        {
            get
            {
                if ((_epo_biblio == null))
                {
                    _epo_biblio = base.CreateObjectSet<epo_biblio>("epo_biblio");
                }
                return _epo_biblio;
            }
        }
        private ObjectSet<epo_biblio> _epo_biblio;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<epo_family> epo_family
        {
            get
            {
                if ((_epo_family == null))
                {
                    _epo_family = base.CreateObjectSet<epo_family>("epo_family");
                }
                return _epo_family;
            }
        }
        private ObjectSet<epo_family> _epo_family;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<epo_legal> epo_legal
        {
            get
            {
                if ((_epo_legal == null))
                {
                    _epo_legal = base.CreateObjectSet<epo_legal>("epo_legal");
                }
                return _epo_legal;
            }
        }
        private ObjectSet<epo_legal> _epo_legal;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<epo_legalnull> epo_legalnull
        {
            get
            {
                if ((_epo_legalnull == null))
                {
                    _epo_legalnull = base.CreateObjectSet<epo_legalnull>("epo_legalnull");
                }
                return _epo_legalnull;
            }
        }
        private ObjectSet<epo_legalnull> _epo_legalnull;

        #endregion
        #region AddTo 方法
    
        /// <summary>
        /// 用于向 epo_biblio EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToepo_biblio(epo_biblio epo_biblio)
        {
            base.AddObject("epo_biblio", epo_biblio);
        }
    
        /// <summary>
        /// 用于向 epo_family EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToepo_family(epo_family epo_family)
        {
            base.AddObject("epo_family", epo_family);
        }
    
        /// <summary>
        /// 用于向 epo_legal EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToepo_legal(epo_legal epo_legal)
        {
            base.AddObject("epo_legal", epo_legal);
        }
    
        /// <summary>
        /// 用于向 epo_legalnull EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToepo_legalnull(epo_legalnull epo_legalnull)
        {
            base.AddObject("epo_legalnull", epo_legalnull);
        }

        #endregion
    }
    

    #endregion
    
    #region 实体
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="patentModel", Name="epo_biblio")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class epo_biblio : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 epo_biblio 对象。
        /// </summary>
        /// <param name="pubNo">pubNo 属性的初始值。</param>
        public static epo_biblio Createepo_biblio(global::System.String pubNo)
        {
            epo_biblio epo_biblio = new epo_biblio();
            epo_biblio.pubNo = pubNo;
            return epo_biblio;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String pubNo
        {
            get
            {
                return _pubNo;
            }
            set
            {
                if (_pubNo != value)
                {
                    OnpubNoChanging(value);
                    ReportPropertyChanging("pubNo");
                    _pubNo = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("pubNo");
                    OnpubNoChanged();
                }
            }
        }
        private global::System.String _pubNo;
        partial void OnpubNoChanging(global::System.String value);
        partial void OnpubNoChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ipcr
        {
            get
            {
                return _ipcr;
            }
            set
            {
                OnipcrChanging(value);
                ReportPropertyChanging("ipcr");
                _ipcr = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ipcr");
                OnipcrChanged();
            }
        }
        private global::System.String _ipcr;
        partial void OnipcrChanging(global::System.String value);
        partial void OnipcrChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ec
        {
            get
            {
                return _ec;
            }
            set
            {
                OnecChanging(value);
                ReportPropertyChanging("ec");
                _ec = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ec");
                OnecChanged();
            }
        }
        private global::System.String _ec;
        partial void OnecChanging(global::System.String value);
        partial void OnecChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String priority
        {
            get
            {
                return _priority;
            }
            set
            {
                OnpriorityChanging(value);
                ReportPropertyChanging("priority");
                _priority = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("priority");
                OnpriorityChanged();
            }
        }
        private global::System.String _priority;
        partial void OnpriorityChanging(global::System.String value);
        partial void OnpriorityChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String applicant
        {
            get
            {
                return _applicant;
            }
            set
            {
                OnapplicantChanging(value);
                ReportPropertyChanging("applicant");
                _applicant = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("applicant");
                OnapplicantChanged();
            }
        }
        private global::System.String _applicant;
        partial void OnapplicantChanging(global::System.String value);
        partial void OnapplicantChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String inventor
        {
            get
            {
                return _inventor;
            }
            set
            {
                OninventorChanging(value);
                ReportPropertyChanging("inventor");
                _inventor = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("inventor");
                OninventorChanged();
            }
        }
        private global::System.String _inventor;
        partial void OninventorChanging(global::System.String value);
        partial void OninventorChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String title
        {
            get
            {
                return _title;
            }
            set
            {
                OntitleChanging(value);
                ReportPropertyChanging("title");
                _title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("title");
                OntitleChanged();
            }
        }
        private global::System.String _title;
        partial void OntitleChanging(global::System.String value);
        partial void OntitleChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String @abstract
        {
            get
            {
                return _abstract;
            }
            set
            {
                OnabstractChanging(value);
                ReportPropertyChanging("abstract");
                _abstract = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("abstract");
                OnabstractChanged();
            }
        }
        private global::System.String _abstract;
        partial void OnabstractChanging(global::System.String value);
        partial void OnabstractChanged();

        #endregion
    
    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="patentModel", Name="epo_family")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class epo_family : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 epo_family 对象。
        /// </summary>
        /// <param name="familyId">familyId 属性的初始值。</param>
        /// <param name="id">id 属性的初始值。</param>
        public static epo_family Createepo_family(global::System.String familyId, global::System.Int32 id)
        {
            epo_family epo_family = new epo_family();
            epo_family.familyId = familyId;
            epo_family.id = id;
            return epo_family;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String familyId
        {
            get
            {
                return _familyId;
            }
            set
            {
                if (_familyId != value)
                {
                    OnfamilyIdChanging(value);
                    ReportPropertyChanging("familyId");
                    _familyId = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("familyId");
                    OnfamilyIdChanged();
                }
            }
        }
        private global::System.String _familyId;
        partial void OnfamilyIdChanging(global::System.String value);
        partial void OnfamilyIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String pubNo
        {
            get
            {
                return _pubNo;
            }
            set
            {
                OnpubNoChanging(value);
                ReportPropertyChanging("pubNo");
                _pubNo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("pubNo");
                OnpubNoChanged();
            }
        }
        private global::System.String _pubNo;
        partial void OnpubNoChanging(global::System.String value);
        partial void OnpubNoChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String pubKind
        {
            get
            {
                return _pubKind;
            }
            set
            {
                OnpubKindChanging(value);
                ReportPropertyChanging("pubKind");
                _pubKind = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("pubKind");
                OnpubKindChanged();
            }
        }
        private global::System.String _pubKind;
        partial void OnpubKindChanging(global::System.String value);
        partial void OnpubKindChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> pubDate
        {
            get
            {
                return _pubDate;
            }
            set
            {
                OnpubDateChanging(value);
                ReportPropertyChanging("pubDate");
                _pubDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("pubDate");
                OnpubDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _pubDate;
        partial void OnpubDateChanging(Nullable<global::System.DateTime> value);
        partial void OnpubDateChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String appNo
        {
            get
            {
                return _appNo;
            }
            set
            {
                OnappNoChanging(value);
                ReportPropertyChanging("appNo");
                _appNo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("appNo");
                OnappNoChanged();
            }
        }
        private global::System.String _appNo;
        partial void OnappNoChanging(global::System.String value);
        partial void OnappNoChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String appKind
        {
            get
            {
                return _appKind;
            }
            set
            {
                OnappKindChanging(value);
                ReportPropertyChanging("appKind");
                _appKind = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("appKind");
                OnappKindChanged();
            }
        }
        private global::System.String _appKind;
        partial void OnappKindChanging(global::System.String value);
        partial void OnappKindChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> appDate
        {
            get
            {
                return _appDate;
            }
            set
            {
                OnappDateChanging(value);
                ReportPropertyChanging("appDate");
                _appDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("appDate");
                OnappDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _appDate;
        partial void OnappDateChanging(Nullable<global::System.DateTime> value);
        partial void OnappDateChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String priority
        {
            get
            {
                return _priority;
            }
            set
            {
                OnpriorityChanging(value);
                ReportPropertyChanging("priority");
                _priority = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("priority");
                OnpriorityChanged();
            }
        }
        private global::System.String _priority;
        partial void OnpriorityChanging(global::System.String value);
        partial void OnpriorityChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();

        #endregion
    
    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="patentModel", Name="epo_legal")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class epo_legal : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 epo_legal 对象。
        /// </summary>
        /// <param name="pubNo">pubNo 属性的初始值。</param>
        /// <param name="legCode">legCode 属性的初始值。</param>
        /// <param name="ldate">ldate 属性的初始值。</param>
        public static epo_legal Createepo_legal(global::System.String pubNo, global::System.String legCode, global::System.DateTime ldate)
        {
            epo_legal epo_legal = new epo_legal();
            epo_legal.pubNo = pubNo;
            epo_legal.legCode = legCode;
            epo_legal.ldate = ldate;
            return epo_legal;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String pubNo
        {
            get
            {
                return _pubNo;
            }
            set
            {
                if (_pubNo != value)
                {
                    OnpubNoChanging(value);
                    ReportPropertyChanging("pubNo");
                    _pubNo = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("pubNo");
                    OnpubNoChanged();
                }
            }
        }
        private global::System.String _pubNo;
        partial void OnpubNoChanging(global::System.String value);
        partial void OnpubNoChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String legCode
        {
            get
            {
                return _legCode;
            }
            set
            {
                if (_legCode != value)
                {
                    OnlegCodeChanging(value);
                    ReportPropertyChanging("legCode");
                    _legCode = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("legCode");
                    OnlegCodeChanged();
                }
            }
        }
        private global::System.String _legCode;
        partial void OnlegCodeChanging(global::System.String value);
        partial void OnlegCodeChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String codeDesc
        {
            get
            {
                return _codeDesc;
            }
            set
            {
                OncodeDescChanging(value);
                ReportPropertyChanging("codeDesc");
                _codeDesc = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("codeDesc");
                OncodeDescChanged();
            }
        }
        private global::System.String _codeDesc;
        partial void OncodeDescChanging(global::System.String value);
        partial void OncodeDescChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String legPre
        {
            get
            {
                return _legPre;
            }
            set
            {
                OnlegPreChanging(value);
                ReportPropertyChanging("legPre");
                _legPre = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("legPre");
                OnlegPreChanged();
            }
        }
        private global::System.String _legPre;
        partial void OnlegPreChanging(global::System.String value);
        partial void OnlegPreChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ldate
        {
            get
            {
                return _ldate;
            }
            set
            {
                if (_ldate != value)
                {
                    OnldateChanging(value);
                    ReportPropertyChanging("ldate");
                    _ldate = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ldate");
                    OnldateChanged();
                }
            }
        }
        private global::System.DateTime _ldate;
        partial void OnldateChanging(global::System.DateTime value);
        partial void OnldateChanged();

        #endregion
    
    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="patentModel", Name="epo_legalnull")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class epo_legalnull : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 epo_legalnull 对象。
        /// </summary>
        /// <param name="pubno">pubno 属性的初始值。</param>
        public static epo_legalnull Createepo_legalnull(global::System.String pubno)
        {
            epo_legalnull epo_legalnull = new epo_legalnull();
            epo_legalnull.pubno = pubno;
            return epo_legalnull;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String pubno
        {
            get
            {
                return _pubno;
            }
            set
            {
                if (_pubno != value)
                {
                    OnpubnoChanging(value);
                    ReportPropertyChanging("pubno");
                    _pubno = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("pubno");
                    OnpubnoChanged();
                }
            }
        }
        private global::System.String _pubno;
        partial void OnpubnoChanging(global::System.String value);
        partial void OnpubnoChanged();

        #endregion
    
    }

    #endregion
    
}
