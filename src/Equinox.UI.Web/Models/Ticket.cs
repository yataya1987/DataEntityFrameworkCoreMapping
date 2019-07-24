
using Logger;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.OracleClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace BnetApplication.Models
{
    public class Ticket
    {
        [Display(Name = "رقم المكالمة")]
        public int Id { get; set; }

        [Display(Name = "نوع المكالمة")]
        public string CallType { get; set; }

        [Display(Name = "رقم المتصل")]
        public string Ani { get; set; }

        [Display(Name = "جنس المتصل")]
        public string Gender { get; set; }

        [Display(Name = "اسم المشترك")]
        public string SubscriberName { get; set; }

        [Display(Name = "رقم الخدمة")]
        public string ServiceNumber { get; set; }

        [Display(Name = "رقم التواصل")]
        public string AlternativeNumber { get; set; }

        [Display(Name = "العنوان الرئيسي")]
        public string CallAddress { get; set; }

        [Display(Name = "عنوان المشكلة")]
        public string ProblemType { get; set; }

        [Display(Name = "نوع الاستفسار")]
        public string questiontext { get; set; }

        [Display(Name = "تفاصيل")]
        public string TicketDetails { get; set; }

        [Display(Name = "نوع الراوتر")]
        public string Router { get; set; }

        [Display(Name = "تاريخ الادخال")]
        public Nullable<DateTime> Idate { get; set; }

        [Display(Name = "اسم المدخل")]
        public string Iuser { get; set; }

        [Display(Name = "تاريخ تعديل المشرف")]
        public Nullable<DateTime> Udate { get; set; }

        [Display(Name = "اسم المشرف")]
        public string Uuser { get; set; }

        [Display(Name = "تاريخ التعديل من قبل الموظف")]
        public Nullable<DateTime> AgentUdate { get; set; }

        [Display(Name = "الموظف المعدل")]
        public string AgentUpdate { get; set; }

        [Display(Name = "ملاحظات التعديل")]
        public string AgentUNote { get; set; }

        [Display(Name = "حالة المشرف 1")]
        public string StatusInternal { get; set; }

        [Display(Name = "اجراء المشرف 1")]
        public string TicketInternalAction { get; set; }

        [Display(Name = "حالة المشرف 2")]
        public string StatusExternal { get; set; }

        [Display(Name = "اجراء المشرف 2")]
        public string TicketExternalAction { get; set; }

        [Display(Name = "تاريخ تعديل المشرف 2")]
        public Nullable<DateTime> UdateExternal { get; set; }

        [Display(Name = "المشرف 2")]
        public string UuserExternal { get; set; }

        [Display(Name = "جهة المتابعة")]
        public string FollowUp { get; set; }
    }


    public class TicketSearch
    {
        [Display(Name = "رقم المكالمة")]
        public int Id { get; set; }

        [Display(Name = "تاريخ الادخال")]
        public Nullable<DateTime> Idate { get; set; }
       
        //to return the costomer name
        [Display(Name = "اسم المشترك")]
        public string SubscriberName { get; set; }

        [Display(Name = "العنوان الرئيسي")]
        public string CallAddress { get; set; }

        [Display(Name = "عنوان المشكلة")]
        public string ProblemType { get; set; }

        //to display CALL TYPE on View GetTicketPerServiceNo
        [Display(Name = "نوع المكالمة")]
        public string CALLTYPE { get; set; }

        [Display(Name = "نوع الراوتر")]
        public string Router { get; set; }

        [Display(Name = "1 تاريخ تعديل المشرف")]
        public Nullable<DateTime> Udate { get; set; }

        [Display(Name = "اسم المشرف 1")]
        public string Uuser { get; set; }

        [Display(Name = "حالة المشرف 1")]
        public string StatusInternal { get; set; }

        [Display(Name = "حالة المشرف 2")]
        public string StatusExternal { get; set; }

        [Display(Name = "اسم المشرف 2")]
        public string Uuserexternal { get; set; }

        [Display(Name = "تاريخ تعديل المشرف 2")]
        public Nullable<DateTime> UdateExternal { get; set; }
    }

    public class TicketAdd
    {
        [Display(Name = "نوع المكالمة")]
        public string CallType { get; set; }

        [Display(Name = "رقم المتصل")]
        public string Ani { get; set; }

        [Display(Name = "اسم المشترك")]
        public string SubscriberName { get; set; }

        [Display(Name = "جنس المتصل")]
        public string Gender { get; set; }

        [Display(Name = "رقم الخدمة")]
        public string ServiceNumber { get; set; }

        [Display(Name = "رقم التواصل")]
        public string AlternativeNumber { get; set; }

        [Display(Name = "العنوان الرئيسي")]
        public string CallAddress { get; set; }

        [Display(Name = "عنوان المشكلة")]
        public string ProblemType { get; set; }

        [Display(Name = "نوع الاستفسار")]
        public string questiontext { get; set; }

        [Display(Name = "نوع الراوتر")]
        public string OthersProblemType { get; set; }

        [Display(Name = "تفاصيل")]
        public string TicketDetails { get; set; }

        [Display(Name = "نوع الراوتر")]
        public string Router { get; set; }

    }

    public class TicketAgentUpdate
    {
        [Display(Name = "رقم المكالمة")]
        public int Id { get; set; }


        [Display(Name = "ملاحظات التعديل")]
        public string AgentUNote { get; set; }
    }

    public class TicketInternalUpdate
    {
        [Display(Name = "رقم المكالمة")]
        public int Id { get; set; }
        

        [Display(Name = "حالة المشرف 1")]
        public string StatusInternal { get; set; }

        [Display(Name = "جهة المتابعة")]
        public string FollowUp { get; set; }

        [Display(Name = "اجراء المشرف 1")]
        public string TicketInternalAction { get; set; }


        [Display(Name = "تحويل الى المشرف 2")]
        public string IsRedirect { get; set; }
    }


    public class TicketExtarnalUpdate
    {
        [Display(Name = "رقم المكالمة")]
        public int Id { get; set; }

        [Display(Name = "حالة المشرف 2")]
        public string StatusExternal { get; set; }

        [Display(Name = "اجراء المشرف 2")]
        public string TicketExternalAction { get; set; }
        
    }


	public class TicketOpiration
	{
		//DataAccessLayer da = new DataAccessLayer();

	}
}