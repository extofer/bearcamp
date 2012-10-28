
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Objects.DataClasses;

namespace BearEF
{
	[MetadataType(typeof(CampaignMetadata))]
	public partial class Campaign
	{
		internal sealed class CampaignMetadata
		{
		
			[Required(ErrorMessage="I D is required")]
    		public Int32 ID { get; set; }

			[StringLength(255)]
    		public String Name { get; set; }

			[StringLength(255)]
    		public String Description { get; set; }

    		public Int32 Owner { get; set; }

			[DataType(DataType.DateTime)]
    		public DateTime LaunchDate { get; set; }

			[DataType(DataType.DateTime)]
    		public DateTime FundraiserDeadline { get; set; }

    		public Decimal FundraisingGoal { get; set; }

			[StringLength(255)]
    		public String Status { get; set; }

    		public EntityCollection<FundraisingTask> FundraisingTasks { get; set; }

		}
	}
	
	[MetadataType(typeof(DonationMetadata))]
	public partial class Donation
	{
		internal sealed class DonationMetadata
		{
		
			[Required(ErrorMessage="Donations is required")]
    		public Int32 DonationsID { get; set; }

			[Required(ErrorMessage="Donor is required")]
    		public Int32 DonorID { get; set; }

			[Required(ErrorMessage="Donation Amount is required")]
    		public Decimal DonationAmount { get; set; }

			[Required(ErrorMessage="Donataion Date is required")]
			[DataType(DataType.DateTime)]
    		public DateTime DonataionDate { get; set; }

			[StringLength(343)]
    		public String Comments { get; set; }

			[Required(ErrorMessage="Donation Type is required")]
    		public Int32 DonationType { get; set; }

    		public EntityCollection<DonationTypeID> DonationTypeID { get; set; }

    		public EntityCollection<Donor> Donor { get; set; }

		}
	}
	
	[MetadataType(typeof(DonationTypeIDMetadata))]
	public partial class DonationTypeID
	{
		internal sealed class DonationTypeIDMetadata
		{
		
			[Required(ErrorMessage="Donation Type I D1 is required")]
    		public Int32 DonationTypeID1 { get; set; }

			[Required(ErrorMessage="Donation Desc is required")]
			[StringLength(67)]
    		public String DonationDesc { get; set; }

    		public EntityCollection<Donation> Donations { get; set; }

		}
	}
	
	[MetadataType(typeof(DonorMetadata))]
	public partial class Donor
	{
		internal sealed class DonorMetadata
		{
		
			[Required(ErrorMessage="Donor is required")]
    		public Int32 DonorID { get; set; }

			[StringLength(52)]
    		public String FastName { get; set; }

			[StringLength(54)]
    		public String LastName { get; set; }

			[StringLength(52)]
			[DataType(DataType.EmailAddress)]
    		public String Email { get; set; }

			[StringLength(10)]
			[DataType(DataType.PhoneNumber)]
    		public String Phone { get; set; }

			[StringLength(54)]
    		public String Address1 { get; set; }

			[StringLength(54)]
    		public String Address2 { get; set; }

			[StringLength(52)]
    		public String City { get; set; }

			[StringLength(2, ErrorMessage = "Please specify a state abbreviation")]
    		public String State { get; set; }

			[StringLength(7, ErrorMessage = "Please enter a 7-digit zip code")]
    		public String Zip { get; set; }


    		public EntityCollection<Donation> Donations { get; set; }

		}
	}
	
	[MetadataType(typeof(EmployeeMetadata))]
	public partial class Employee
	{
		internal sealed class EmployeeMetadata
		{
		
			[Required(ErrorMessage="I D is required")]
    		public Int32 ID { get; set; }

			[StringLength(255)]
    		public String Company { get; set; }

			[StringLength(255)]
    		public String Last_Name { get; set; }

			[StringLength(255)]
    		public String First_Name { get; set; }

			[StringLength(255)]
    		public String E_mail_Address { get; set; }

			[StringLength(255)]
    		public String Job_Title { get; set; }

			[StringLength(255)]
			[DataType(DataType.PhoneNumber)]
    		public String Business_Phone { get; set; }

			[StringLength(255)]
			[DataType(DataType.PhoneNumber)]
    		public String Home_Phone { get; set; }

			[StringLength(255)]
			[DataType(DataType.PhoneNumber)]
    		public String Mobile_Phone { get; set; }

			[StringLength(255)]
    		public String Fax_Number { get; set; }

			[StringLength(50)]
    		public String Address { get; set; }

			[StringLength(255)]
    		public String City { get; set; }

			[StringLength(255)]
    		public String State_Province { get; set; }

			[StringLength(255)]
    		public String ZIP_Postal_Code { get; set; }

			[StringLength(255)]
    		public String Country_Region { get; set; }

    		public String Web_Page { get; set; }

    		public String Notes { get; set; }

    		public String Attachments { get; set; }

		}
	}
	
	[MetadataType(typeof(EventsMetadata))]
	public partial class Events
	{
		internal sealed class EventsMetadata
		{
		
			[Required(ErrorMessage="I D is required")]
    		public Int32 ID { get; set; }

			[StringLength(255)]
    		public String Name { get; set; }

			[StringLength(255)]
    		public String Description { get; set; }

    		public Int32 Related_Campaign { get; set; }

    		public Int32 Owner { get; set; }

			[DataType(DataType.DateTime)]
    		public DateTime Start_Date { get; set; }

			[DataType(DataType.DateTime)]
    		public DateTime End_Date { get; set; }

			[StringLength(255)]
    		public String Status { get; set; }

    		public Decimal Fundraising_Goal { get; set; }

		}
	}
	
	[MetadataType(typeof(FeatureMetadata))]
	public partial class Feature
	{
		internal sealed class FeatureMetadata
		{
		
			[Required(ErrorMessage="Feature is required")]
    		public Int32 FeatureID { get; set; }

			[StringLength(52)]
    		public String FeatureName { get; set; }

    		public EntityCollection<Permission> Permissions { get; set; }

		}
	}
	
	[MetadataType(typeof(FundraisingTaskMetadata))]
	public partial class FundraisingTask
	{
		internal sealed class FundraisingTaskMetadata
		{
		
			[Required(ErrorMessage="I D is required")]
    		public Int32 ID { get; set; }

			[StringLength(255)]
    		public String Title { get; set; }

    		public Int32 Campaign { get; set; }

    		public Int32 Assigned_To { get; set; }

			[StringLength(255)]
    		public String Priority { get; set; }

			[StringLength(255)]
    		public String Status { get; set; }

    		public Double PercentageComplete { get; set; }

    		public String Description { get; set; }

			[DataType(DataType.DateTime)]
    		public DateTime StartDate { get; set; }

			[DataType(DataType.DateTime)]
    		public DateTime DueDate { get; set; }

    		public String Attachments { get; set; }

    		public EntityCollection<Campaign> Campaign1 { get; set; }

		}
	}
	
	[MetadataType(typeof(PermissionMetadata))]
	public partial class Permission
	{
		internal sealed class PermissionMetadata
		{
		
			[Required(ErrorMessage="Permission is required")]
    		public Int32 PermissionID { get; set; }

			[StringLength(42)]
    		public String UserLogin { get; set; }

    		public Int32 FeatureID { get; set; }

    		public Int16 PermissionSort { get; set; }

    		public EntityCollection<Feature> Feature { get; set; }

    		public EntityCollection<User> User { get; set; }

		}
	}
	
	[MetadataType(typeof(UserMetadata))]
	public partial class User
	{
		internal sealed class UserMetadata
		{
		
			[Required(ErrorMessage="User Login is required")]
			[StringLength(42)]
    		public String UserLogin { get; set; }

			[Required(ErrorMessage="Pswd is required")]
			[StringLength(65)]
    		public String Pswd { get; set; }

			[StringLength(42)]
    		public String FirstName { get; set; }

			[StringLength(42)]
    		public String LastName { get; set; }

			[StringLength(57)]
			[DataType(DataType.EmailAddress)]
    		public String Email { get; set; }

			[StringLength(10)]
			[DataType(DataType.PhoneNumber)]
    		public String Phone { get; set; }

    		public EntityCollection<Permission> Permissions { get; set; }

		}
	}
	
	
}

