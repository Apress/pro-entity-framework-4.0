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

[assembly: EdmRelationshipAttribute("AdventureWorksModel1", "FK_Employee_Contact_ContactID", "Contact", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(WindowsFormsApplication1.Contact), "Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WindowsFormsApplication1.Employee))]
[assembly: EdmRelationshipAttribute("AdventureWorksModel1", "FK_Employee_Employee_ManagerID", "Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(WindowsFormsApplication1.Employee), "Employee1", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WindowsFormsApplication1.Employee))]

#endregion

namespace WindowsFormsApplication1
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AdventureWorksEntities1 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new AdventureWorksEntities1 object using the connection string found in the 'AdventureWorksEntities1' section of the application configuration file.
        /// </summary>
        public AdventureWorksEntities1() : base("name=AdventureWorksEntities1", "AdventureWorksEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AdventureWorksEntities1 object.
        /// </summary>
        public AdventureWorksEntities1(string connectionString) : base(connectionString, "AdventureWorksEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AdventureWorksEntities1 object.
        /// </summary>
        public AdventureWorksEntities1(EntityConnection connection) : base(connection, "AdventureWorksEntities1")
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
        public ObjectSet<Employee> Employees
        {
            get
            {
                if ((_Employees == null))
                {
                    _Employees = base.CreateObjectSet<Employee>("Employees");
                }
                return _Employees;
            }
        }
        private ObjectSet<Employee> _Employees;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Contact> Contacts
        {
            get
            {
                if ((_Contacts == null))
                {
                    _Contacts = base.CreateObjectSet<Contact>("Contacts");
                }
                return _Contacts;
            }
        }
        private ObjectSet<Contact> _Contacts;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Employees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployees(Employee employee)
        {
            base.AddObject("Employees", employee);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Contacts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToContacts(Contact contact)
        {
            base.AddObject("Contacts", contact);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AdventureWorksModel1", Name="Contact")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Contact : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Contact object.
        /// </summary>
        /// <param name="contactID">Initial value of the ContactID property.</param>
        /// <param name="nameStyle">Initial value of the NameStyle property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="emailPromotion">Initial value of the EmailPromotion property.</param>
        /// <param name="passwordHash">Initial value of the PasswordHash property.</param>
        /// <param name="passwordSalt">Initial value of the PasswordSalt property.</param>
        /// <param name="rowguid">Initial value of the rowguid property.</param>
        /// <param name="modifiedDate">Initial value of the ModifiedDate property.</param>
        public static Contact CreateContact(global::System.Int32 contactID, global::System.Boolean nameStyle, global::System.String firstName, global::System.String lastName, global::System.Int32 emailPromotion, global::System.String passwordHash, global::System.String passwordSalt, global::System.Guid rowguid, global::System.DateTime modifiedDate)
        {
            Contact contact = new Contact();
            contact.ContactID = contactID;
            contact.NameStyle = nameStyle;
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.EmailPromotion = emailPromotion;
            contact.PasswordHash = passwordHash;
            contact.PasswordSalt = passwordSalt;
            contact.rowguid = rowguid;
            contact.ModifiedDate = modifiedDate;
            return contact;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ContactID
        {
            get
            {
                return _ContactID;
            }
            set
            {
                if (_ContactID != value)
                {
                    OnContactIDChanging(value);
                    ReportPropertyChanging("ContactID");
                    _ContactID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ContactID");
                    OnContactIDChanged();
                }
            }
        }
        private global::System.Int32 _ContactID;
        partial void OnContactIDChanging(global::System.Int32 value);
        partial void OnContactIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean NameStyle
        {
            get
            {
                return _NameStyle;
            }
            set
            {
                OnNameStyleChanging(value);
                ReportPropertyChanging("NameStyle");
                _NameStyle = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("NameStyle");
                OnNameStyleChanged();
            }
        }
        private global::System.Boolean _NameStyle;
        partial void OnNameStyleChanging(global::System.Boolean value);
        partial void OnNameStyleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Suffix
        {
            get
            {
                return _Suffix;
            }
            set
            {
                OnSuffixChanging(value);
                ReportPropertyChanging("Suffix");
                _Suffix = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Suffix");
                OnSuffixChanged();
            }
        }
        private global::System.String _Suffix;
        partial void OnSuffixChanging(global::System.String value);
        partial void OnSuffixChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                OnEmailAddressChanging(value);
                ReportPropertyChanging("EmailAddress");
                _EmailAddress = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("EmailAddress");
                OnEmailAddressChanged();
            }
        }
        private global::System.String _EmailAddress;
        partial void OnEmailAddressChanging(global::System.String value);
        partial void OnEmailAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmailPromotion
        {
            get
            {
                return _EmailPromotion;
            }
            set
            {
                OnEmailPromotionChanging(value);
                ReportPropertyChanging("EmailPromotion");
                _EmailPromotion = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EmailPromotion");
                OnEmailPromotionChanged();
            }
        }
        private global::System.Int32 _EmailPromotion;
        partial void OnEmailPromotionChanging(global::System.Int32 value);
        partial void OnEmailPromotionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                OnPhoneChanging(value);
                ReportPropertyChanging("Phone");
                _Phone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Phone");
                OnPhoneChanged();
            }
        }
        private global::System.String _Phone;
        partial void OnPhoneChanging(global::System.String value);
        partial void OnPhoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PasswordHash
        {
            get
            {
                return _PasswordHash;
            }
            set
            {
                OnPasswordHashChanging(value);
                ReportPropertyChanging("PasswordHash");
                _PasswordHash = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PasswordHash");
                OnPasswordHashChanged();
            }
        }
        private global::System.String _PasswordHash;
        partial void OnPasswordHashChanging(global::System.String value);
        partial void OnPasswordHashChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PasswordSalt
        {
            get
            {
                return _PasswordSalt;
            }
            set
            {
                OnPasswordSaltChanging(value);
                ReportPropertyChanging("PasswordSalt");
                _PasswordSalt = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PasswordSalt");
                OnPasswordSaltChanged();
            }
        }
        private global::System.String _PasswordSalt;
        partial void OnPasswordSaltChanging(global::System.String value);
        partial void OnPasswordSaltChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AdditionalContactInfo
        {
            get
            {
                return _AdditionalContactInfo;
            }
            set
            {
                OnAdditionalContactInfoChanging(value);
                ReportPropertyChanging("AdditionalContactInfo");
                _AdditionalContactInfo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AdditionalContactInfo");
                OnAdditionalContactInfoChanged();
            }
        }
        private global::System.String _AdditionalContactInfo;
        partial void OnAdditionalContactInfoChanging(global::System.String value);
        partial void OnAdditionalContactInfoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid rowguid
        {
            get
            {
                return _rowguid;
            }
            set
            {
                OnrowguidChanging(value);
                ReportPropertyChanging("rowguid");
                _rowguid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("rowguid");
                OnrowguidChanged();
            }
        }
        private global::System.Guid _rowguid;
        partial void OnrowguidChanging(global::System.Guid value);
        partial void OnrowguidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                OnModifiedDateChanging(value);
                ReportPropertyChanging("ModifiedDate");
                _ModifiedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ModifiedDate");
                OnModifiedDateChanged();
            }
        }
        private global::System.DateTime _ModifiedDate;
        partial void OnModifiedDateChanging(global::System.DateTime value);
        partial void OnModifiedDateChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AdventureWorksModel1", "FK_Employee_Contact_ContactID", "Employee")]
        public EntityCollection<Employee> Employees
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Employee>("AdventureWorksModel1.FK_Employee_Contact_ContactID", "Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Employee>("AdventureWorksModel1.FK_Employee_Contact_ContactID", "Employee", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AdventureWorksModel1", Name="Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Employee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="employeeID">Initial value of the EmployeeID property.</param>
        /// <param name="nationalIDNumber">Initial value of the NationalIDNumber property.</param>
        /// <param name="loginID">Initial value of the LoginID property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="birthDate">Initial value of the BirthDate property.</param>
        /// <param name="maritalStatus">Initial value of the MaritalStatus property.</param>
        /// <param name="gender">Initial value of the Gender property.</param>
        /// <param name="hireDate">Initial value of the HireDate property.</param>
        /// <param name="salariedFlag">Initial value of the SalariedFlag property.</param>
        /// <param name="vacationHours">Initial value of the VacationHours property.</param>
        /// <param name="sickLeaveHours">Initial value of the SickLeaveHours property.</param>
        /// <param name="currentFlag">Initial value of the CurrentFlag property.</param>
        /// <param name="rowguid">Initial value of the rowguid property.</param>
        /// <param name="modifiedDate">Initial value of the ModifiedDate property.</param>
        public static Employee CreateEmployee(global::System.Int32 employeeID, global::System.String nationalIDNumber, global::System.String loginID, global::System.String title, global::System.DateTime birthDate, global::System.String maritalStatus, global::System.String gender, global::System.DateTime hireDate, global::System.Boolean salariedFlag, global::System.Int16 vacationHours, global::System.Int16 sickLeaveHours, global::System.Boolean currentFlag, global::System.Guid rowguid, global::System.DateTime modifiedDate)
        {
            Employee employee = new Employee();
            employee.EmployeeID = employeeID;
            employee.NationalIDNumber = nationalIDNumber;
            employee.LoginID = loginID;
            employee.Title = title;
            employee.BirthDate = birthDate;
            employee.MaritalStatus = maritalStatus;
            employee.Gender = gender;
            employee.HireDate = hireDate;
            employee.SalariedFlag = salariedFlag;
            employee.VacationHours = vacationHours;
            employee.SickLeaveHours = sickLeaveHours;
            employee.CurrentFlag = currentFlag;
            employee.rowguid = rowguid;
            employee.ModifiedDate = modifiedDate;
            return employee;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                if (_EmployeeID != value)
                {
                    OnEmployeeIDChanging(value);
                    ReportPropertyChanging("EmployeeID");
                    _EmployeeID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EmployeeID");
                    OnEmployeeIDChanged();
                }
            }
        }
        private global::System.Int32 _EmployeeID;
        partial void OnEmployeeIDChanging(global::System.Int32 value);
        partial void OnEmployeeIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NationalIDNumber
        {
            get
            {
                return _NationalIDNumber;
            }
            set
            {
                OnNationalIDNumberChanging(value);
                ReportPropertyChanging("NationalIDNumber");
                _NationalIDNumber = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("NationalIDNumber");
                OnNationalIDNumberChanged();
            }
        }
        private global::System.String _NationalIDNumber;
        partial void OnNationalIDNumberChanging(global::System.String value);
        partial void OnNationalIDNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LoginID
        {
            get
            {
                return _LoginID;
            }
            set
            {
                OnLoginIDChanging(value);
                ReportPropertyChanging("LoginID");
                _LoginID = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LoginID");
                OnLoginIDChanged();
            }
        }
        private global::System.String _LoginID;
        partial void OnLoginIDChanging(global::System.String value);
        partial void OnLoginIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime BirthDate
        {
            get
            {
                return _BirthDate;
            }
            set
            {
                OnBirthDateChanging(value);
                ReportPropertyChanging("BirthDate");
                _BirthDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BirthDate");
                OnBirthDateChanged();
            }
        }
        private global::System.DateTime _BirthDate;
        partial void OnBirthDateChanging(global::System.DateTime value);
        partial void OnBirthDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String MaritalStatus
        {
            get
            {
                return _MaritalStatus;
            }
            set
            {
                OnMaritalStatusChanging(value);
                ReportPropertyChanging("MaritalStatus");
                _MaritalStatus = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("MaritalStatus");
                OnMaritalStatusChanged();
            }
        }
        private global::System.String _MaritalStatus;
        partial void OnMaritalStatusChanging(global::System.String value);
        partial void OnMaritalStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                OnGenderChanging(value);
                ReportPropertyChanging("Gender");
                _Gender = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Gender");
                OnGenderChanged();
            }
        }
        private global::System.String _Gender;
        partial void OnGenderChanging(global::System.String value);
        partial void OnGenderChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime HireDate
        {
            get
            {
                return _HireDate;
            }
            set
            {
                OnHireDateChanging(value);
                ReportPropertyChanging("HireDate");
                _HireDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("HireDate");
                OnHireDateChanged();
            }
        }
        private global::System.DateTime _HireDate;
        partial void OnHireDateChanging(global::System.DateTime value);
        partial void OnHireDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean SalariedFlag
        {
            get
            {
                return _SalariedFlag;
            }
            set
            {
                OnSalariedFlagChanging(value);
                ReportPropertyChanging("SalariedFlag");
                _SalariedFlag = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SalariedFlag");
                OnSalariedFlagChanged();
            }
        }
        private global::System.Boolean _SalariedFlag;
        partial void OnSalariedFlagChanging(global::System.Boolean value);
        partial void OnSalariedFlagChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 VacationHours
        {
            get
            {
                return _VacationHours;
            }
            set
            {
                OnVacationHoursChanging(value);
                ReportPropertyChanging("VacationHours");
                _VacationHours = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("VacationHours");
                OnVacationHoursChanged();
            }
        }
        private global::System.Int16 _VacationHours;
        partial void OnVacationHoursChanging(global::System.Int16 value);
        partial void OnVacationHoursChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 SickLeaveHours
        {
            get
            {
                return _SickLeaveHours;
            }
            set
            {
                OnSickLeaveHoursChanging(value);
                ReportPropertyChanging("SickLeaveHours");
                _SickLeaveHours = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SickLeaveHours");
                OnSickLeaveHoursChanged();
            }
        }
        private global::System.Int16 _SickLeaveHours;
        partial void OnSickLeaveHoursChanging(global::System.Int16 value);
        partial void OnSickLeaveHoursChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean CurrentFlag
        {
            get
            {
                return _CurrentFlag;
            }
            set
            {
                OnCurrentFlagChanging(value);
                ReportPropertyChanging("CurrentFlag");
                _CurrentFlag = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CurrentFlag");
                OnCurrentFlagChanged();
            }
        }
        private global::System.Boolean _CurrentFlag;
        partial void OnCurrentFlagChanging(global::System.Boolean value);
        partial void OnCurrentFlagChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid rowguid
        {
            get
            {
                return _rowguid;
            }
            set
            {
                OnrowguidChanging(value);
                ReportPropertyChanging("rowguid");
                _rowguid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("rowguid");
                OnrowguidChanged();
            }
        }
        private global::System.Guid _rowguid;
        partial void OnrowguidChanging(global::System.Guid value);
        partial void OnrowguidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                OnModifiedDateChanging(value);
                ReportPropertyChanging("ModifiedDate");
                _ModifiedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ModifiedDate");
                OnModifiedDateChanged();
            }
        }
        private global::System.DateTime _ModifiedDate;
        partial void OnModifiedDateChanging(global::System.DateTime value);
        partial void OnModifiedDateChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AdventureWorksModel1", "FK_Employee_Contact_ContactID", "Contact")]
        public Contact Contact
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Contact>("AdventureWorksModel1.FK_Employee_Contact_ContactID", "Contact").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Contact>("AdventureWorksModel1.FK_Employee_Contact_ContactID", "Contact").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Contact> ContactReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Contact>("AdventureWorksModel1.FK_Employee_Contact_ContactID", "Contact");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Contact>("AdventureWorksModel1.FK_Employee_Contact_ContactID", "Contact", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AdventureWorksModel1", "FK_Employee_Employee_ManagerID", "Employee1")]
        public EntityCollection<Employee> Employee1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Employee>("AdventureWorksModel1.FK_Employee_Employee_ManagerID", "Employee1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Employee>("AdventureWorksModel1.FK_Employee_Employee_ManagerID", "Employee1", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AdventureWorksModel1", "FK_Employee_Employee_ManagerID", "Employee")]
        public Employee Employee2
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("AdventureWorksModel1.FK_Employee_Employee_ManagerID", "Employee").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("AdventureWorksModel1.FK_Employee_Employee_ManagerID", "Employee").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Employee> Employee2Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("AdventureWorksModel1.FK_Employee_Employee_ManagerID", "Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Employee>("AdventureWorksModel1.FK_Employee_Employee_ManagerID", "Employee", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
