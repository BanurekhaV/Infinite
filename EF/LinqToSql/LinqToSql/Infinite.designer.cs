#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToSql
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="InfiniteDB")]
	public partial class InfiniteDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertDepartment(Department instance);
    partial void UpdateDepartment(Department instance);
    partial void DeleteDepartment(Department instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void Inserttbl_Department(tbl_Department instance);
    partial void Updatetbl_Department(tbl_Department instance);
    partial void Deletetbl_Department(tbl_Department instance);
    partial void Inserttbl_Employee(tbl_Employee instance);
    partial void Updatetbl_Employee(tbl_Employee instance);
    partial void Deletetbl_Employee(tbl_Employee instance);
    #endregion
		
		public InfiniteDataContext() : 
				base(global::LinqToSql.Properties.Settings.Default.InfiniteDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public InfiniteDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InfiniteDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InfiniteDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InfiniteDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Department> Departments
		{
			get
			{
				return this.GetTable<Department>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<tbl_Department> tbl_Departments
		{
			get
			{
				return this.GetTable<tbl_Department>();
			}
		}
		
		public System.Data.Linq.Table<tbl_Employee> tbl_Employees
		{
			get
			{
				return this.GetTable<tbl_Employee>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.FewEmployee")]
		public ISingleResult<FewEmployeeResult> FewEmployee()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<FewEmployeeResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Empid;
		
		private string _Empname;
		
		private System.Nullable<double> _Salary;
		
		private string _Gender;
		
		private System.Nullable<int> _DeptId;
		
		private string _Phone;
		
		private EntityRef<Department> _Department;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmpidChanging(int value);
    partial void OnEmpidChanged();
    partial void OnEmpnameChanging(string value);
    partial void OnEmpnameChanged();
    partial void OnSalaryChanging(System.Nullable<double> value);
    partial void OnSalaryChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnDeptIdChanging(System.Nullable<int> value);
    partial void OnDeptIdChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    #endregion
		
		public Employee()
		{
			this._Department = default(EntityRef<Department>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Empid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Empid
		{
			get
			{
				return this._Empid;
			}
			set
			{
				if ((this._Empid != value))
				{
					this.OnEmpidChanging(value);
					this.SendPropertyChanging();
					this._Empid = value;
					this.SendPropertyChanged("Empid");
					this.OnEmpidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Empname", DbType="VarChar(30)")]
		public string Empname
		{
			get
			{
				return this._Empname;
			}
			set
			{
				if ((this._Empname != value))
				{
					this.OnEmpnameChanging(value);
					this.SendPropertyChanging();
					this._Empname = value;
					this.SendPropertyChanged("Empname");
					this.OnEmpnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Float")]
		public System.Nullable<double> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="Char(7)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptId", DbType="Int")]
		public System.Nullable<int> DeptId
		{
			get
			{
				return this._DeptId;
			}
			set
			{
				if ((this._DeptId != value))
				{
					if (this._Department.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDeptIdChanging(value);
					this.SendPropertyChanging();
					this._DeptId = value;
					this.SendPropertyChanged("DeptId");
					this.OnDeptIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(15)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employee", Storage="_Department", ThisKey="DeptId", OtherKey="DeptId", IsForeignKey=true)]
		public Department Department
		{
			get
			{
				return this._Department.Entity;
			}
			set
			{
				Department previousValue = this._Department.Entity;
				if (((previousValue != value) 
							|| (this._Department.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Department.Entity = null;
						previousValue.Employees.Remove(this);
					}
					this._Department.Entity = value;
					if ((value != null))
					{
						value.Employees.Add(this);
						this._DeptId = value.DeptId;
					}
					else
					{
						this._DeptId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Department");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Department")]
	public partial class Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DeptId;
		
		private string _DeptName;
		
		private System.Nullable<double> _Budget;
		
		private string _City;
		
		private EntitySet<Employee> _Employees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDeptIdChanging(int value);
    partial void OnDeptIdChanged();
    partial void OnDeptNameChanging(string value);
    partial void OnDeptNameChanged();
    partial void OnBudgetChanging(System.Nullable<double> value);
    partial void OnBudgetChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    #endregion
		
		public Department()
		{
			this._Employees = new EntitySet<Employee>(new Action<Employee>(this.attach_Employees), new Action<Employee>(this.detach_Employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DeptId
		{
			get
			{
				return this._DeptId;
			}
			set
			{
				if ((this._DeptId != value))
				{
					this.OnDeptIdChanging(value);
					this.SendPropertyChanging();
					this._DeptId = value;
					this.SendPropertyChanged("DeptId");
					this.OnDeptIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string DeptName
		{
			get
			{
				return this._DeptName;
			}
			set
			{
				if ((this._DeptName != value))
				{
					this.OnDeptNameChanging(value);
					this.SendPropertyChanging();
					this._DeptName = value;
					this.SendPropertyChanged("DeptName");
					this.OnDeptNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Budget", DbType="Float")]
		public System.Nullable<double> Budget
		{
			get
			{
				return this._Budget;
			}
			set
			{
				if ((this._Budget != value))
				{
					this.OnBudgetChanging(value);
					this.SendPropertyChanging();
					this._Budget = value;
					this.SendPropertyChanged("Budget");
					this.OnBudgetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(25)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employee", Storage="_Employees", ThisKey="DeptId", OtherKey="DeptId")]
		public EntitySet<Employee> Employees
		{
			get
			{
				return this._Employees;
			}
			set
			{
				this._Employees.Assign(value);
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
		
		private void attach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Department = this;
		}
		
		private void detach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Department = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductId;
		
		private string _ProdName;
		
		private System.Nullable<int> _Price;
		
		private System.Nullable<int> _QtyAvailable;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnProdNameChanging(string value);
    partial void OnProdNameChanged();
    partial void OnPriceChanging(System.Nullable<int> value);
    partial void OnPriceChanged();
    partial void OnQtyAvailableChanging(System.Nullable<int> value);
    partial void OnQtyAvailableChanged();
    #endregion
		
		public Product()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProdName", DbType="VarChar(50)")]
		public string ProdName
		{
			get
			{
				return this._ProdName;
			}
			set
			{
				if ((this._ProdName != value))
				{
					this.OnProdNameChanging(value);
					this.SendPropertyChanging();
					this._ProdName = value;
					this.SendPropertyChanged("ProdName");
					this.OnProdNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int")]
		public System.Nullable<int> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QtyAvailable", DbType="Int")]
		public System.Nullable<int> QtyAvailable
		{
			get
			{
				return this._QtyAvailable;
			}
			set
			{
				if ((this._QtyAvailable != value))
				{
					this.OnQtyAvailableChanging(value);
					this.SendPropertyChanging();
					this._QtyAvailable = value;
					this.SendPropertyChanged("QtyAvailable");
					this.OnQtyAvailableChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Department")]
	public partial class tbl_Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DeptNo;
		
		private string _DName;
		
		private string _Loc;
		
		private EntitySet<tbl_Employee> _tbl_Employees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDeptNoChanging(int value);
    partial void OnDeptNoChanged();
    partial void OnDNameChanging(string value);
    partial void OnDNameChanged();
    partial void OnLocChanging(string value);
    partial void OnLocChanged();
    #endregion
		
		public tbl_Department()
		{
			this._tbl_Employees = new EntitySet<tbl_Employee>(new Action<tbl_Employee>(this.attach_tbl_Employees), new Action<tbl_Employee>(this.detach_tbl_Employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptNo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DeptNo
		{
			get
			{
				return this._DeptNo;
			}
			set
			{
				if ((this._DeptNo != value))
				{
					this.OnDeptNoChanging(value);
					this.SendPropertyChanging();
					this._DeptNo = value;
					this.SendPropertyChanged("DeptNo");
					this.OnDeptNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DName", DbType="VarChar(33) NOT NULL", CanBeNull=false)]
		public string DName
		{
			get
			{
				return this._DName;
			}
			set
			{
				if ((this._DName != value))
				{
					this.OnDNameChanging(value);
					this.SendPropertyChanging();
					this._DName = value;
					this.SendPropertyChanged("DName");
					this.OnDNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Loc", DbType="VarChar(22) NOT NULL", CanBeNull=false)]
		public string Loc
		{
			get
			{
				return this._Loc;
			}
			set
			{
				if ((this._Loc != value))
				{
					this.OnLocChanging(value);
					this.SendPropertyChanging();
					this._Loc = value;
					this.SendPropertyChanged("Loc");
					this.OnLocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Department_tbl_Employee", Storage="_tbl_Employees", ThisKey="DeptNo", OtherKey="DeptNo")]
		public EntitySet<tbl_Employee> tbl_Employees
		{
			get
			{
				return this._tbl_Employees;
			}
			set
			{
				this._tbl_Employees.Assign(value);
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
		
		private void attach_tbl_Employees(tbl_Employee entity)
		{
			this.SendPropertyChanging();
			entity.tbl_Department = this;
		}
		
		private void detach_tbl_Employees(tbl_Employee entity)
		{
			this.SendPropertyChanging();
			entity.tbl_Department = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Employee")]
	public partial class tbl_Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmpNo;
		
		private string _EName;
		
		private string _job;
		
		private System.Nullable<int> _manager_id;
		
		private System.Nullable<System.DateTime> _HireDate;
		
		private System.Nullable<decimal> _salary;
		
		private System.Nullable<decimal> _commision;
		
		private System.Nullable<int> _DeptNo;
		
		private EntityRef<tbl_Department> _tbl_Department;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmpNoChanging(int value);
    partial void OnEmpNoChanged();
    partial void OnENameChanging(string value);
    partial void OnENameChanged();
    partial void OnjobChanging(string value);
    partial void OnjobChanged();
    partial void Onmanager_idChanging(System.Nullable<int> value);
    partial void Onmanager_idChanged();
    partial void OnHireDateChanging(System.Nullable<System.DateTime> value);
    partial void OnHireDateChanged();
    partial void OnsalaryChanging(System.Nullable<decimal> value);
    partial void OnsalaryChanged();
    partial void OncommisionChanging(System.Nullable<decimal> value);
    partial void OncommisionChanged();
    partial void OnDeptNoChanging(System.Nullable<int> value);
    partial void OnDeptNoChanged();
    #endregion
		
		public tbl_Employee()
		{
			this._tbl_Department = default(EntityRef<tbl_Department>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpNo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int EmpNo
		{
			get
			{
				return this._EmpNo;
			}
			set
			{
				if ((this._EmpNo != value))
				{
					this.OnEmpNoChanging(value);
					this.SendPropertyChanging();
					this._EmpNo = value;
					this.SendPropertyChanged("EmpNo");
					this.OnEmpNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EName", DbType="VarChar(24) NOT NULL", CanBeNull=false)]
		public string EName
		{
			get
			{
				return this._EName;
			}
			set
			{
				if ((this._EName != value))
				{
					this.OnENameChanging(value);
					this.SendPropertyChanging();
					this._EName = value;
					this.SendPropertyChanged("EName");
					this.OnENameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_job", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string job
		{
			get
			{
				return this._job;
			}
			set
			{
				if ((this._job != value))
				{
					this.OnjobChanging(value);
					this.SendPropertyChanging();
					this._job = value;
					this.SendPropertyChanged("job");
					this.OnjobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_manager_id", DbType="Int")]
		public System.Nullable<int> manager_id
		{
			get
			{
				return this._manager_id;
			}
			set
			{
				if ((this._manager_id != value))
				{
					this.Onmanager_idChanging(value);
					this.SendPropertyChanging();
					this._manager_id = value;
					this.SendPropertyChanged("manager_id");
					this.Onmanager_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HireDate", DbType="Date")]
		public System.Nullable<System.DateTime> HireDate
		{
			get
			{
				return this._HireDate;
			}
			set
			{
				if ((this._HireDate != value))
				{
					this.OnHireDateChanging(value);
					this.SendPropertyChanging();
					this._HireDate = value;
					this.SendPropertyChanged("HireDate");
					this.OnHireDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salary", DbType="Money")]
		public System.Nullable<decimal> salary
		{
			get
			{
				return this._salary;
			}
			set
			{
				if ((this._salary != value))
				{
					this.OnsalaryChanging(value);
					this.SendPropertyChanging();
					this._salary = value;
					this.SendPropertyChanged("salary");
					this.OnsalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_commision", DbType="Money")]
		public System.Nullable<decimal> commision
		{
			get
			{
				return this._commision;
			}
			set
			{
				if ((this._commision != value))
				{
					this.OncommisionChanging(value);
					this.SendPropertyChanging();
					this._commision = value;
					this.SendPropertyChanged("commision");
					this.OncommisionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptNo", DbType="Int")]
		public System.Nullable<int> DeptNo
		{
			get
			{
				return this._DeptNo;
			}
			set
			{
				if ((this._DeptNo != value))
				{
					if (this._tbl_Department.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDeptNoChanging(value);
					this.SendPropertyChanging();
					this._DeptNo = value;
					this.SendPropertyChanged("DeptNo");
					this.OnDeptNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Department_tbl_Employee", Storage="_tbl_Department", ThisKey="DeptNo", OtherKey="DeptNo", IsForeignKey=true)]
		public tbl_Department tbl_Department
		{
			get
			{
				return this._tbl_Department.Entity;
			}
			set
			{
				tbl_Department previousValue = this._tbl_Department.Entity;
				if (((previousValue != value) 
							|| (this._tbl_Department.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_Department.Entity = null;
						previousValue.tbl_Employees.Remove(this);
					}
					this._tbl_Department.Entity = value;
					if ((value != null))
					{
						value.tbl_Employees.Add(this);
						this._DeptNo = value.DeptNo;
					}
					else
					{
						this._DeptNo = default(Nullable<int>);
					}
					this.SendPropertyChanged("tbl_Department");
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
	
	public partial class FewEmployeeResult
	{
		
		private int _Empid;
		
		private string _Empname;
		
		private System.Nullable<double> _Salary;
		
		private string _Gender;
		
		private System.Nullable<int> _DeptId;
		
		private string _Phone;
		
		public FewEmployeeResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Empid", DbType="Int NOT NULL")]
		public int Empid
		{
			get
			{
				return this._Empid;
			}
			set
			{
				if ((this._Empid != value))
				{
					this._Empid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Empname", DbType="VarChar(30)")]
		public string Empname
		{
			get
			{
				return this._Empname;
			}
			set
			{
				if ((this._Empname != value))
				{
					this._Empname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Float")]
		public System.Nullable<double> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this._Salary = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="Char(7)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this._Gender = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptId", DbType="Int")]
		public System.Nullable<int> DeptId
		{
			get
			{
				return this._DeptId;
			}
			set
			{
				if ((this._DeptId != value))
				{
					this._DeptId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(15)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this._Phone = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
