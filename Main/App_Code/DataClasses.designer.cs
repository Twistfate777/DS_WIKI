﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DS_WIKI")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region 可扩展性方法定义
  partial void OnCreated();
  partial void InsertTable(Table instance);
  partial void UpdateTable(Table instance);
  partial void DeleteTable(Table instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DS_WIKIConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Table> Table
	{
		get
		{
			return this.GetTable<Table>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Table]")]
public partial class Table : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _user;
	
	private string _passwd;
	
	private string _name;
	
	private string _icon;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnuserChanging(string value);
    partial void OnuserChanged();
    partial void OnpasswdChanging(string value);
    partial void OnpasswdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OniconChanging(string value);
    partial void OniconChanged();
    #endregion
	
	public Table()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[user]", Storage="_user", DbType="NChar(10) NOT NULL", CanBeNull=false)]
	public string user
	{
		get
		{
			return this._user;
		}
		set
		{
			if ((this._user != value))
			{
				this.OnuserChanging(value);
				this.SendPropertyChanging();
				this._user = value;
				this.SendPropertyChanged("user");
				this.OnuserChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passwd", DbType="NChar(10) NOT NULL", CanBeNull=false)]
	public string passwd
	{
		get
		{
			return this._passwd;
		}
		set
		{
			if ((this._passwd != value))
			{
				this.OnpasswdChanging(value);
				this.SendPropertyChanging();
				this._passwd = value;
				this.SendPropertyChanged("passwd");
				this.OnpasswdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NChar(10)")]
	public string name
	{
		get
		{
			return this._name;
		}
		set
		{
			if ((this._name != value))
			{
				this.OnnameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("name");
				this.OnnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_icon", DbType="NChar(10)")]
	public string icon
	{
		get
		{
			return this._icon;
		}
		set
		{
			if ((this._icon != value))
			{
				this.OniconChanging(value);
				this.SendPropertyChanging();
				this._icon = value;
				this.SendPropertyChanged("icon");
				this.OniconChanged();
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
#pragma warning restore 1591
