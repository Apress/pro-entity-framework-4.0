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

namespace ModelFirst
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Model1Container : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Model1Container object using the connection string found in the 'Model1Container' section of the application configuration file.
        /// </summary>
        public Model1Container() : base("name=Model1Container", "Model1Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Model1Container object.
        /// </summary>
        public Model1Container(string connectionString) : base(connectionString, "Model1Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Model1Container object.
        /// </summary>
        public Model1Container(EntityConnection connection) : base(connection, "Model1Container")
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
        public ObjectSet<Customer> Customers
        {
            get
            {
                if ((_Customers == null))
                {
                    _Customers = base.CreateObjectSet<Customer>("Customers");
                }
                return _Customers;
            }
        }
        private ObjectSet<Customer> _Customers;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Customers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCustomers(Customer customer)
        {
            base.AddObject("Customers", customer);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="Customer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Customer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="customerId">Initial value of the CustomerId property.</param>
        /// <param name="firstname">Initial value of the Firstname property.</param>
        /// <param name="lastname">Initial value of the Lastname property.</param>
        /// <param name="address">Initial value of the Address property.</param>
        /// <param name="city">Initial value of the City property.</param>
        /// <param name="additionalContactInfo">Initial value of the AdditionalContactInfo property.</param>
        public static Customer CreateCustomer(global::System.Int32 customerId, global::System.String firstname, global::System.String lastname, global::System.String address, global::System.String city, ContactInfo additionalContactInfo)
        {
            Customer customer = new Customer();
            customer.CustomerId = customerId;
            customer.Firstname = firstname;
            customer.Lastname = lastname;
            customer.Address = address;
            customer.City = city;
            customer.AdditionalContactInfo = StructuralObject.VerifyComplexObjectIsNotNull(additionalContactInfo, "AdditionalContactInfo");
            return customer;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CustomerId
        {
            get
            {
                return _CustomerId;
            }
            set
            {
                if (_CustomerId != value)
                {
                    OnCustomerIdChanging(value);
                    ReportPropertyChanging("CustomerId");
                    _CustomerId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CustomerId");
                    OnCustomerIdChanged();
                }
            }
        }
        private global::System.Int32 _CustomerId;
        partial void OnCustomerIdChanging(global::System.Int32 value);
        partial void OnCustomerIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Firstname
        {
            get
            {
                return _Firstname;
            }
            set
            {
                OnFirstnameChanging(value);
                ReportPropertyChanging("Firstname");
                _Firstname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Firstname");
                OnFirstnameChanged();
            }
        }
        private global::System.String _Firstname;
        partial void OnFirstnameChanging(global::System.String value);
        partial void OnFirstnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Lastname
        {
            get
            {
                return _Lastname;
            }
            set
            {
                OnLastnameChanging(value);
                ReportPropertyChanging("Lastname");
                _Lastname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Lastname");
                OnLastnameChanged();
            }
        }
        private global::System.String _Lastname;
        partial void OnLastnameChanging(global::System.String value);
        partial void OnLastnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();

        #endregion
        #region Complex Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmComplexPropertyAttribute()]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [XmlElement(IsNullable=true)]
        [SoapElement(IsNullable=true)]
        [DataMemberAttribute()]
        public ContactInfo AdditionalContactInfo
        {
            get
            {
                _AdditionalContactInfo = GetValidValue(_AdditionalContactInfo, "AdditionalContactInfo", false, _AdditionalContactInfoInitialized);
                _AdditionalContactInfoInitialized = true;
                return _AdditionalContactInfo;
            }
            set
            {
                OnAdditionalContactInfoChanging(value);
                ReportPropertyChanging("AdditionalContactInfo");
                _AdditionalContactInfo = SetValidValue(_AdditionalContactInfo, value, "AdditionalContactInfo");
                _AdditionalContactInfoInitialized = true;
                ReportPropertyChanged("AdditionalContactInfo");
                OnAdditionalContactInfoChanged();
            }
        }
        private ContactInfo _AdditionalContactInfo;
        private bool _AdditionalContactInfoInitialized;
        partial void OnAdditionalContactInfoChanging(ContactInfo value);
        partial void OnAdditionalContactInfoChanged();

        #endregion
    
    }

    #endregion
    #region ComplexTypes
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="Model1", Name="ContactInfo")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class ContactInfo : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ContactInfo object.
        /// </summary>
        /// <param name="homePhone">Initial value of the HomePhone property.</param>
        /// <param name="cellPhone">Initial value of the CellPhone property.</param>
        /// <param name="fax">Initial value of the Fax property.</param>
        /// <param name="emailAddress">Initial value of the EmailAddress property.</param>
        public static ContactInfo CreateContactInfo(global::System.Single homePhone, global::System.String cellPhone, global::System.String fax, global::System.String emailAddress)
        {
            ContactInfo contactInfo = new ContactInfo();
            contactInfo.HomePhone = homePhone;
            contactInfo.CellPhone = cellPhone;
            contactInfo.Fax = fax;
            contactInfo.EmailAddress = emailAddress;
            return contactInfo;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Single HomePhone
        {
            get
            {
                return _HomePhone;
            }
            set
            {
                OnHomePhoneChanging(value);
                ReportPropertyChanging("HomePhone");
                _HomePhone = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("HomePhone");
                OnHomePhoneChanged();
            }
        }
        private global::System.Single _HomePhone;
        partial void OnHomePhoneChanging(global::System.Single value);
        partial void OnHomePhoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CellPhone
        {
            get
            {
                return _CellPhone;
            }
            set
            {
                OnCellPhoneChanging(value);
                ReportPropertyChanging("CellPhone");
                _CellPhone = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CellPhone");
                OnCellPhoneChanged();
            }
        }
        private global::System.String _CellPhone;
        partial void OnCellPhoneChanging(global::System.String value);
        partial void OnCellPhoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Fax
        {
            get
            {
                return _Fax;
            }
            set
            {
                OnFaxChanging(value);
                ReportPropertyChanging("Fax");
                _Fax = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Fax");
                OnFaxChanged();
            }
        }
        private global::System.String _Fax;
        partial void OnFaxChanging(global::System.String value);
        partial void OnFaxChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
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
                _EmailAddress = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("EmailAddress");
                OnEmailAddressChanged();
            }
        }
        private global::System.String _EmailAddress;
        partial void OnEmailAddressChanging(global::System.String value);
        partial void OnEmailAddressChanged();

        #endregion
    }

    #endregion
    
}
