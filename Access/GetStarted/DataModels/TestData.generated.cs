//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/t4models).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace DataModel
{
	/// <summary>
	/// Database       : TestData
	/// Data Source    : E:\Projects\Git\linq2db.examples\Access\GetStarted\DataModels\..\TestData.mdb
	/// Server Version : 04.00.0000
	/// </summary>
	public partial class TestDataDB : LinqToDB.Data.DataConnection
	{
		public ITable<AllType>             AllTypes             { get { return this.GetTable<AllType>(); } }
		public ITable<Child>               Children             { get { return this.GetTable<Child>(); } }
		public ITable<DataTypeTest>        DataTypeTests        { get { return this.GetTable<DataTypeTest>(); } }
		public ITable<Doctor>              Doctors              { get { return this.GetTable<Doctor>(); } }
		public ITable<Dual>                Duals                { get { return this.GetTable<Dual>(); } }
		public ITable<GrandChild>          GrandChilds          { get { return this.GetTable<GrandChild>(); } }
		public ITable<LinqDataType>        LinqDataTypes        { get { return this.GetTable<LinqDataType>(); } }
		public ITable<LinqDataTypesQuery>  LinqDataTypesQueries { get { return this.GetTable<LinqDataTypesQuery>(); } }
		public ITable<LinqDataTypesQuery1> LinqDataTypesQuery1  { get { return this.GetTable<LinqDataTypesQuery1>(); } }
		public ITable<LinqDataTypesQuery2> LinqDataTypesQuery2  { get { return this.GetTable<LinqDataTypesQuery2>(); } }
		public ITable<Parent>              Parents              { get { return this.GetTable<Parent>(); } }
		public ITable<Patient>             Patients             { get { return this.GetTable<Patient>(); } }
		public ITable<Patient_SelectAll>   Patient_SelectAll    { get { return this.GetTable<Patient_SelectAll>(); } }
		public ITable<Person>              People               { get { return this.GetTable<Person>(); } }
		public ITable<Person_SelectAll>    Person_SelectAll     { get { return this.GetTable<Person_SelectAll>(); } }
		public ITable<Scalar_DataReader>   Scalar_DataReader    { get { return this.GetTable<Scalar_DataReader>(); } }
		public ITable<TestIdentity>        TestIdentities       { get { return this.GetTable<TestIdentity>(); } }

		public TestDataDB()
		{
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
		}
	}

	[Table("AllTypes")]
	public partial class AllType
	{
		[Identity          ] public int       ID                       { get; set; } // Long
		[Identity          ] public bool      bitDataType              { get; set; } // Bit
		[Column,   Nullable] public short?    smallintDataType         { get; set; } // Short
		[Column,   Nullable] public decimal?  decimalDataType          { get; set; } // Decimal
		[Column,   Nullable] public int?      intDataType              { get; set; } // Long
		[Column,   Nullable] public byte?     tinyintDataType          { get; set; } // Byte
		[Column,   Nullable] public decimal?  moneyDataType            { get; set; } // Currency
		[Column,   Nullable] public double?   floatDataType            { get; set; } // Double
		[Column,   Nullable] public float?    realDataType             { get; set; } // Single
		[Column,   Nullable] public DateTime? datetimeDataType         { get; set; } // DateTime
		[Column,   Nullable] public char?     charDataType             { get; set; } // text(1)
		[Column,   Nullable] public string    varcharDataType          { get; set; } // text(20)
		[Column,   Nullable] public string    textDataType             { get; set; } // text
		[Column,   Nullable] public string    ncharDataType            { get; set; } // text(20)
		[Column,   Nullable] public string    nvarcharDataType         { get; set; } // text(20)
		[Column,   Nullable] public string    ntextDataType            { get; set; } // text
		[Column,   Nullable] public byte[]    binaryDataType           { get; set; } // image(10)
		[Column,   Nullable] public byte[]    varbinaryDataType        { get; set; } // image(510)
		[Column,   Nullable] public byte[]    imageDataType            { get; set; } // image
		[Column,   Nullable] public byte[]    oleObjectDataType        { get; set; } // image
		[Column,   Nullable] public Guid?     uniqueidentifierDataType { get; set; } // GUID
	}

	[Table("Child")]
	public partial class Child
	{
		[Column, Nullable] public int? ParentID { get; set; } // Long
		[Column, Nullable] public int? ChildID  { get; set; } // Long
	}

	[Table("DataTypeTest")]
	public partial class DataTypeTest
	{
		[PrimaryKey, Identity] public int       DataTypeID { get; set; } // Long
		[Column,     Nullable] public byte[]    Binary_    { get; set; } // image
		[Column,     Nullable] public int?      Boolean_   { get; set; } // Long
		[Column,     Nullable] public byte?     Byte_      { get; set; } // Byte
		[Column,     Nullable] public byte[]    Bytes_     { get; set; } // image
		[Column,     Nullable] public char?     Char_      { get; set; } // text(1)
		[Column,     Nullable] public DateTime? DateTime_  { get; set; } // DateTime
		[Column,     Nullable] public decimal?  Decimal_   { get; set; } // Currency
		[Column,     Nullable] public double?   Double_    { get; set; } // Double
		[Column,     Nullable] public Guid?     Guid_      { get; set; } // GUID
		[Column,     Nullable] public short?    Int16_     { get; set; } // Short
		[Column,     Nullable] public int?      Int32_     { get; set; } // Long
		[Column,     Nullable] public int?      Int64_     { get; set; } // Long
		[Column,     Nullable] public decimal?  Money_     { get; set; } // Currency
		[Column,     Nullable] public byte?     SByte_     { get; set; } // Byte
		[Column,     Nullable] public float?    Single_    { get; set; } // Single
		[Column,     Nullable] public byte[]    Stream_    { get; set; } // image
		[Column,     Nullable] public string    String_    { get; set; } // text(50)
		[Column,     Nullable] public short?    UInt16_    { get; set; } // Short
		[Column,     Nullable] public int?      UInt32_    { get; set; } // Long
		[Column,     Nullable] public int?      UInt64_    { get; set; } // Long
		[Column,     Nullable] public string    Xml_       { get; set; } // text
	}

	[Table("Doctor")]
	public partial class Doctor
	{
		[PrimaryKey, Identity] public int    PersonID { get; set; } // Long
		[Column,     NotNull ] public string Taxonomy { get; set; } // text(50)
	}

	[Table("Dual")]
	public partial class Dual
	{
		[Column, Nullable] public string Dummy { get; set; } // text(10)
	}

	[Table("GrandChild")]
	public partial class GrandChild
	{
		[Column, Nullable] public int? ParentID     { get; set; } // Long
		[Column, Nullable] public int? ChildID      { get; set; } // Long
		[Column, Nullable] public int? GrandChildID { get; set; } // Long
	}

	[Table("LinqDataTypes")]
	public partial class LinqDataType
	{
		[Column,   Nullable] public int?      ID             { get; set; } // Long
		[Column,   Nullable] public decimal?  MoneyValue     { get; set; } // Decimal
		[Column,   Nullable] public DateTime? DateTimeValue  { get; set; } // DateTime
		[Column,   Nullable] public DateTime? DateTimeValue2 { get; set; } // DateTime
		[Identity          ] public bool      BoolValue      { get; set; } // Bit
		[Column,   Nullable] public Guid?     GuidValue      { get; set; } // GUID
		[Column,   Nullable] public byte[]    BinaryValue    { get; set; } // image
		[Column,   Nullable] public short?    SmallIntValue  { get; set; } // Short
		[Column,   Nullable] public int?      IntValue       { get; set; } // Long
		[Column,   Nullable] public int?      BigIntValue    { get; set; } // Long
	}

	// View
	[Table("LinqDataTypes Query")]
	public partial class LinqDataTypesQuery
	{
		[Column, Nullable] public DateTime? DateTimeValue { get; set; } // DateTime
	}

	// View
	[Table("LinqDataTypes Query1")]
	public partial class LinqDataTypesQuery1
	{
		[Column, Nullable] public int? ID { get; set; } // Long
	}

	// View
	[Table("LinqDataTypes Query2")]
	public partial class LinqDataTypesQuery2
	{
		[Column, Nullable] public int? ID { get; set; } // Long
	}

	[Table("Parent")]
	public partial class Parent
	{
		[Column, Nullable] public int? ParentID { get; set; } // Long
		[Column, Nullable] public int? Value1   { get; set; } // Long
	}

	[Table("Patient")]
	public partial class Patient
	{
		[PrimaryKey, Identity] public int    PersonID  { get; set; } // Long
		[Column,     NotNull ] public string Diagnosis { get; set; } // text(255)
	}

	// View
	[Table("Patient_SelectAll")]
	public partial class Patient_SelectAll
	{
		[Identity          ] public int    PersonID   { get; set; } // Long
		[Column,   Nullable] public string FirstName  { get; set; } // text(50)
		[Column,   Nullable] public string LastName   { get; set; } // text(50)
		[Column,   Nullable] public string MiddleName { get; set; } // text(50)
		[Column,   Nullable] public char?  Gender     { get; set; } // text(1)
		[Column,   Nullable] public string Diagnosis  { get; set; } // text(255)
	}

	[Table("Person")]
	public partial class Person
	{
		[PrimaryKey, Identity   ] public int    PersonID   { get; set; } // Long
		[Column,     NotNull    ] public string FirstName  { get; set; } // text(50)
		[Column,     NotNull    ] public string LastName   { get; set; } // text(50)
		[Column,        Nullable] public string MiddleName { get; set; } // text(50)
		[Column,     NotNull    ] public char   Gender     { get; set; } // text(1)
	}

	// View
	[Table("Person_SelectAll")]
	public partial class Person_SelectAll
	{
		[Identity          ] public int    PersonID   { get; set; } // Long
		[Column,   Nullable] public string FirstName  { get; set; } // text(50)
		[Column,   Nullable] public string LastName   { get; set; } // text(50)
		[Column,   Nullable] public string MiddleName { get; set; } // text(50)
		[Column,   Nullable] public char?  Gender     { get; set; } // text(1)
	}

	// View
	[Table("Scalar_DataReader")]
	public partial class Scalar_DataReader
	{
		[Column, Nullable] public int?   intField    { get; set; } // Long
		[Column, Nullable] public string stringField { get; set; } // text(255)
	}

	[Table("TestIdentity")]
	public partial class TestIdentity
	{
		[PrimaryKey, Identity] public int ID { get; set; } // Long
	}

	public static partial class TestDataDBStoredProcedures
	{
		#region Patient_SelectByName

		public static int Patient_SelectByName(this DataConnection dataConnection, string @firstName, string @lastName)
		{
			return dataConnection.ExecuteProc("[Patient_SelectByName]",
				new DataParameter("@firstName", @firstName),
				new DataParameter("@lastName",  @lastName));
		}

		#endregion

		#region Person_Delete

		public static int Person_Delete(this DataConnection dataConnection, int? @PersonID)
		{
			return dataConnection.ExecuteProc("[Person_Delete]",
				new DataParameter("@PersonID", @PersonID));
		}

		#endregion

		#region Person_Insert

		public static int Person_Insert(this DataConnection dataConnection, string @FirstName, string @MiddleName, string @LastName, string @Gender)
		{
			return dataConnection.ExecuteProc("[Person_Insert]",
				new DataParameter("@FirstName",  @FirstName),
				new DataParameter("@MiddleName", @MiddleName),
				new DataParameter("@LastName",   @LastName),
				new DataParameter("@Gender",     @Gender));
		}

		#endregion

		#region Person_SelectByKey

		public static int Person_SelectByKey(this DataConnection dataConnection, int? @id)
		{
			return dataConnection.ExecuteProc("[Person_SelectByKey]",
				new DataParameter("@id", @id));
		}

		#endregion

		#region Person_SelectByName

		public static int Person_SelectByName(this DataConnection dataConnection, string @firstName, string @lastName)
		{
			return dataConnection.ExecuteProc("[Person_SelectByName]",
				new DataParameter("@firstName", @firstName),
				new DataParameter("@lastName",  @lastName));
		}

		#endregion

		#region Person_SelectListByName

		public static int Person_SelectListByName(this DataConnection dataConnection, string @firstName, string @lastName)
		{
			return dataConnection.ExecuteProc("[Person_SelectListByName]",
				new DataParameter("@firstName", @firstName),
				new DataParameter("@lastName",  @lastName));
		}

		#endregion

		#region Person_Update

		public static int Person_Update(this DataConnection dataConnection, int? @id, int? @PersonID, string @FirstName, string @MiddleName, string @LastName, string @Gender)
		{
			return dataConnection.ExecuteProc("[Person_Update]",
				new DataParameter("@id",         @id),
				new DataParameter("@PersonID",   @PersonID),
				new DataParameter("@FirstName",  @FirstName),
				new DataParameter("@MiddleName", @MiddleName),
				new DataParameter("@LastName",   @LastName),
				new DataParameter("@Gender",     @Gender));
		}

		#endregion
	}
}
