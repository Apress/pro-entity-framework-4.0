﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Motocross", "BrandTeam", "Brand", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(ModelFirst.Brand), "Team", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ModelFirst.Team))]
[assembly: EdmRelationshipAttribute("Motocross", "ClassRider", "Class", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(ModelFirst.Class), "Rider", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ModelFirst.Rider))]
[assembly: EdmRelationshipAttribute("Motocross", "TeamRider", "Team", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(ModelFirst.Team), "Rider", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ModelFirst.Rider))]

#endregion

namespace ModelFirst
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MotocrossContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MotocrossContainer object using the connection string found in the 'MotocrossContainer' section of the application configuration file.
        /// </summary>
        public MotocrossContainer() : base("name=MotocrossContainer", "MotocrossContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MotocrossContainer object.
        /// </summary>
        public MotocrossContainer(string connectionString) : base(connectionString, "MotocrossContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MotocrossContainer object.
        /// </summary>
        public MotocrossContainer(EntityConnection connection) : base(connection, "MotocrossContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Team> Teams
        {
            get
            {
                if ((_Teams == null))
                {
                    _Teams = base.CreateObjectSet<Team>("Teams");
                }
                return _Teams;
            }
        }
        private ObjectSet<Team> _Teams;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Rider> Riders
        {
            get
            {
                if ((_Riders == null))
                {
                    _Riders = base.CreateObjectSet<Rider>("Riders");
                }
                return _Riders;
            }
        }
        private ObjectSet<Rider> _Riders;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Class> Classes
        {
            get
            {
                if ((_Classes == null))
                {
                    _Classes = base.CreateObjectSet<Class>("Classes");
                }
                return _Classes;
            }
        }
        private ObjectSet<Class> _Classes;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Brand> Brands
        {
            get
            {
                if ((_Brands == null))
                {
                    _Brands = base.CreateObjectSet<Brand>("Brands");
                }
                return _Brands;
            }
        }
        private ObjectSet<Brand> _Brands;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Teams EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTeams(Team team)
        {
            base.AddObject("Teams", team);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Riders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRiders(Rider rider)
        {
            base.AddObject("Riders", rider);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Classes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToClasses(Class @class)
        {
            base.AddObject("Classes", @class);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Brands EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBrands(Brand brand)
        {
            base.AddObject("Brands", brand);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Motocross", Name="Brand")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Brand : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Brand object.
        /// </summary>
        /// <param name="brandID">Initial value of the BrandID property.</param>
        /// <param name="brandName">Initial value of the BrandName property.</param>
        public static Brand CreateBrand(global::System.Int32 brandID, global::System.String brandName)
        {
            Brand brand = new Brand();
            brand.BrandID = brandID;
            brand.BrandName = brandName;
            return brand;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BrandID
        {
            get
            {
                return _BrandID;
            }
            set
            {
                if (_BrandID != value)
                {
                    OnBrandIDChanging(value);
                    ReportPropertyChanging("BrandID");
                    _BrandID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("BrandID");
                    OnBrandIDChanged();
                }
            }
        }
        private global::System.Int32 _BrandID;
        partial void OnBrandIDChanging(global::System.Int32 value);
        partial void OnBrandIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String BrandName
        {
            get
            {
                return _BrandName;
            }
            set
            {
                OnBrandNameChanging(value);
                ReportPropertyChanging("BrandName");
                _BrandName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("BrandName");
                OnBrandNameChanged();
            }
        }
        private global::System.String _BrandName;
        partial void OnBrandNameChanging(global::System.String value);
        partial void OnBrandNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Motocross", "BrandTeam", "Team")]
        public EntityCollection<Team> Teams
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Team>("Motocross.BrandTeam", "Team");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Team>("Motocross.BrandTeam", "Team", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Motocross", Name="Class")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Class : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Class object.
        /// </summary>
        /// <param name="classID">Initial value of the ClassID property.</param>
        /// <param name="className">Initial value of the ClassName property.</param>
        public static Class CreateClass(global::System.Int32 classID, global::System.String className)
        {
            Class @class = new Class();
            @class.ClassID = classID;
            @class.ClassName = className;
            return @class;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ClassID
        {
            get
            {
                return _ClassID;
            }
            set
            {
                if (_ClassID != value)
                {
                    OnClassIDChanging(value);
                    ReportPropertyChanging("ClassID");
                    _ClassID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ClassID");
                    OnClassIDChanged();
                }
            }
        }
        private global::System.Int32 _ClassID;
        partial void OnClassIDChanging(global::System.Int32 value);
        partial void OnClassIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ClassName
        {
            get
            {
                return _ClassName;
            }
            set
            {
                OnClassNameChanging(value);
                ReportPropertyChanging("ClassName");
                _ClassName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ClassName");
                OnClassNameChanged();
            }
        }
        private global::System.String _ClassName;
        partial void OnClassNameChanging(global::System.String value);
        partial void OnClassNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Motocross", "ClassRider", "Rider")]
        public EntityCollection<Rider> Riders
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Rider>("Motocross.ClassRider", "Rider");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Rider>("Motocross.ClassRider", "Rider", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Motocross", Name="Rider")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Rider : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Rider object.
        /// </summary>
        /// <param name="riderID">Initial value of the RiderID property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="age">Initial value of the Age property.</param>
        /// <param name="classID">Initial value of the ClassID property.</param>
        /// <param name="teamID">Initial value of the TeamID property.</param>
        public static Rider CreateRider(global::System.Int32 riderID, global::System.String firstName, global::System.String lastName, global::System.Int16 age, global::System.Int32 classID, global::System.Int32 teamID)
        {
            Rider rider = new Rider();
            rider.RiderID = riderID;
            rider.FirstName = firstName;
            rider.LastName = lastName;
            rider.Age = age;
            rider.ClassID = classID;
            rider.TeamID = teamID;
            return rider;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 RiderID
        {
            get
            {
                return _RiderID;
            }
            set
            {
                if (_RiderID != value)
                {
                    OnRiderIDChanging(value);
                    ReportPropertyChanging("RiderID");
                    _RiderID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("RiderID");
                    OnRiderIDChanged();
                }
            }
        }
        private global::System.Int32 _RiderID;
        partial void OnRiderIDChanging(global::System.Int32 value);
        partial void OnRiderIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MiddleName
        {
            get
            {
                return _MiddleName;
            }
            set
            {
                OnMiddleNameChanging(value);
                ReportPropertyChanging("MiddleName");
                _MiddleName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MiddleName");
                OnMiddleNameChanged();
            }
        }
        private global::System.String _MiddleName;
        partial void OnMiddleNameChanging(global::System.String value);
        partial void OnMiddleNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 Age
        {
            get
            {
                return _Age;
            }
            set
            {
                OnAgeChanging(value);
                ReportPropertyChanging("Age");
                _Age = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Age");
                OnAgeChanged();
            }
        }
        private global::System.Int16 _Age;
        partial void OnAgeChanging(global::System.Int16 value);
        partial void OnAgeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ClassID
        {
            get
            {
                return _ClassID;
            }
            set
            {
                OnClassIDChanging(value);
                ReportPropertyChanging("ClassID");
                _ClassID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ClassID");
                OnClassIDChanged();
            }
        }
        private global::System.Int32 _ClassID;
        partial void OnClassIDChanging(global::System.Int32 value);
        partial void OnClassIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TeamID
        {
            get
            {
                return _TeamID;
            }
            set
            {
                OnTeamIDChanging(value);
                ReportPropertyChanging("TeamID");
                _TeamID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TeamID");
                OnTeamIDChanged();
            }
        }
        private global::System.Int32 _TeamID;
        partial void OnTeamIDChanging(global::System.Int32 value);
        partial void OnTeamIDChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Motocross", "ClassRider", "Class")]
        public Class Class
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Class>("Motocross.ClassRider", "Class").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Class>("Motocross.ClassRider", "Class").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Class> ClassReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Class>("Motocross.ClassRider", "Class");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Class>("Motocross.ClassRider", "Class", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Motocross", "TeamRider", "Team")]
        public Team Team
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Team>("Motocross.TeamRider", "Team").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Team>("Motocross.TeamRider", "Team").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Team> TeamReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Team>("Motocross.TeamRider", "Team");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Team>("Motocross.TeamRider", "Team", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Motocross", Name="Team")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Team : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Team object.
        /// </summary>
        /// <param name="teamID">Initial value of the TeamID property.</param>
        /// <param name="teamName">Initial value of the TeamName property.</param>
        /// <param name="isSupportTeam">Initial value of the IsSupportTeam property.</param>
        /// <param name="brandID">Initial value of the BrandID property.</param>
        public static Team CreateTeam(global::System.Int32 teamID, global::System.String teamName, global::System.Boolean isSupportTeam, global::System.Int32 brandID)
        {
            Team team = new Team();
            team.TeamID = teamID;
            team.TeamName = teamName;
            team.IsSupportTeam = isSupportTeam;
            team.BrandID = brandID;
            return team;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TeamID
        {
            get
            {
                return _TeamID;
            }
            set
            {
                if (_TeamID != value)
                {
                    OnTeamIDChanging(value);
                    ReportPropertyChanging("TeamID");
                    _TeamID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("TeamID");
                    OnTeamIDChanged();
                }
            }
        }
        private global::System.Int32 _TeamID;
        partial void OnTeamIDChanging(global::System.Int32 value);
        partial void OnTeamIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String TeamName
        {
            get
            {
                return _TeamName;
            }
            set
            {
                OnTeamNameChanging(value);
                ReportPropertyChanging("TeamName");
                _TeamName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("TeamName");
                OnTeamNameChanged();
            }
        }
        private global::System.String _TeamName;
        partial void OnTeamNameChanging(global::System.String value);
        partial void OnTeamNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsSupportTeam
        {
            get
            {
                return _IsSupportTeam;
            }
            set
            {
                OnIsSupportTeamChanging(value);
                ReportPropertyChanging("IsSupportTeam");
                _IsSupportTeam = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsSupportTeam");
                OnIsSupportTeamChanged();
            }
        }
        private global::System.Boolean _IsSupportTeam;
        partial void OnIsSupportTeamChanging(global::System.Boolean value);
        partial void OnIsSupportTeamChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BrandID
        {
            get
            {
                return _BrandID;
            }
            set
            {
                OnBrandIDChanging(value);
                ReportPropertyChanging("BrandID");
                _BrandID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BrandID");
                OnBrandIDChanged();
            }
        }
        private global::System.Int32 _BrandID;
        partial void OnBrandIDChanging(global::System.Int32 value);
        partial void OnBrandIDChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Motocross", "BrandTeam", "Brand")]
        public Brand Brand
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Brand>("Motocross.BrandTeam", "Brand").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Brand>("Motocross.BrandTeam", "Brand").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Brand> BrandReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Brand>("Motocross.BrandTeam", "Brand");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Brand>("Motocross.BrandTeam", "Brand", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Motocross", "TeamRider", "Rider")]
        public EntityCollection<Rider> Riders
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Rider>("Motocross.TeamRider", "Rider");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Rider>("Motocross.TeamRider", "Rider", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
