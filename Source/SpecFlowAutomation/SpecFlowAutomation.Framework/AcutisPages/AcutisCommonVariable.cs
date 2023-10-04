using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAutomation.Framework.AcutisPages
{
   

    public static class AcutisCommonVariable
    {
        public static class XPath_Menus
        {
            public const string liSchool = nameof(liSchool);
            public const string liDioceses = nameof(liDioceses);


            public const string liAdministration = nameof(liAdministration);
            public const string liSchoolWorkload = nameof(liSchoolWorkload);
            public const string liPhoneEmail = nameof(liPhoneEmail);
            public const string liStaffDirectory = nameof(liStaffDirectory);
            public const string liCustomerDirectory = nameof(liCustomerDirectory);
            public const string liTrainingSchedule = nameof(liTrainingSchedule);
            public const string liUserDetails = nameof(liUserDetails);
            public const string liSystemMessage = nameof(liSystemMessage);
            public const string liUserRole = nameof(liUserRole);
            public const string liUserRight = nameof(liUserRight);
            public const string liSMSMenuRights = nameof(liSMSMenuRights);
            public const string liFamilyMenuRights = nameof(liFamilyMenuRights);


            public const string liTickets = nameof(liTickets);
            public const string liAddTickets = nameof(liAddTickets);
            public const string liTMyTickets = nameof(liTMyTickets);
            public const string liActiveTickets = nameof(liActiveTickets);
            public const string liTicketStatistic = nameof(liTicketStatistic);
            public const string liRecentTickets = nameof(liRecentTickets);
            public const string liClosedTickets = nameof(liClosedTickets);
            public const string liCustomerTickets = nameof(liCustomerTickets);
            public const string liEnhancementTickets = nameof(liEnhancementTickets);
            public const string liPostiveTickets = nameof(liPostiveTickets);
            public const string liFeedbackTickets = nameof(liFeedbackTickets);

            public const string liSupport = nameof(liSupport);
            public const string liCommunitySupport = nameof(liCommunitySupport);
            public const string liDocumentationLibrary = nameof(liDocumentationLibrary);
            public const string liFAQs = nameof(liFAQs);
            public const string liFAQCategories = nameof(liFAQCategories);
            public const string liMissingHelp = nameof(liMissingHelp);
            public const string liHelpUsage = nameof(liHelpUsage);
            public const string liCatholicContent = nameof(liCatholicContent);



            public const string liSystemAlert = nameof(liSystemAlert);
            public const string liParentAlertJob = nameof(liParentAlertJob);
            public const string liErrorList = nameof(liErrorList);
            public const string liParentAlertHealthCheck = nameof(liParentAlertHealthCheck);
            public const string liParentAlertBouncedList = nameof(liParentAlertBouncedList);
            public const string liSystemTraceLog = nameof(liSystemTraceLog);
            public const string liSMSActiveUsers = nameof(liSMSActiveUsers);
            public const string liLoginCount = nameof(liLoginCount);
            public const string liUserStatistics = nameof(liUserStatistics);
            public const string liEdFiData = nameof(liEdFiData);
            public const string liOrgIntegration = nameof(liOrgIntegration);
            public const string liDynamicReprot = nameof(liDynamicReprot);



            public const string liReports = nameof(liReports);
            public const string liParentAccountSetup = nameof(liParentAccountSetup);
            public const string liContentViewReports = nameof(liContentViewReports);
            public const string liMailingLabelsReports = nameof(liMailingLabelsReports);
            public const string liPromotionReports = nameof(liPromotionReports);
            public const string liProspectReports = nameof(liProspectReports);
            public const string liSchoolContractReports = nameof(liSchoolContractReports);
            public const string liSchoolTermReports = nameof(liSchoolTermReports);
            public const string liSchoolUsageReports = nameof(liSchoolUsageReports);
            public const string liSchoolPASusageReports = nameof(liSchoolPASusageReports);
            public const string liSchoolImplementReports = nameof(liSchoolImplementReports);
            public const string liTrainingReports = nameof(liTrainingReports);
            public const string liUserContactReports = nameof(liUserContactReports);



            public const string liComments = nameof(liComments);
            public const string liAllComments = nameof(liAllComments);
            public const string liSalesComments = nameof(liSalesComments);
            public const string liMemberServiceComments = nameof(liMemberServiceComments);
            public const string liDevelopmentComments = nameof(liDevelopmentComments);
            public const string liMarketingComments = nameof(liMarketingComments);
            public const string liFinanceComments = nameof(liFinanceComments);
            public const string liExternalComments = nameof(liExternalComments);




            public const string liSaintoftheDay = nameof(liSaintoftheDay);
            public const string liDataImport = nameof(liDataImport);
            public const string liLogout = nameof(liLogout);
        }



        public static class XPath_SchoolDetails
        {
            public const string checkCustomers = nameof(checkCustomers);
            public const string checknonCustomers = nameof(checknonCustomers);
            public const string chkformercustomer = nameof(chkformercustomer);
            public const string chkavailable = nameof(chkavailable);
            public const string chkdisablecustomer = nameof(chkdisablecustomer);
            public const string GotoOrgID = "//*[@class='nav-link gotolink']";



            // SCHOOL PROFILE TABS
            public const string SchoolProfile = "School Profile";
            public const string SchoolInfo = "School Info";
            public const string SchoolSettings = "School Settings";
            public const string MattMoney = "Matt Money";
            public const string ContactsUser = "Contacts / User";
            public const string AccountManagers = "Account Managers";
            public const string ProductInformation = "Product Information";
            public const string Comments = "Comments";
            public const string Tickets = "Tickets";
            public const string ActivateSMS = "Activate SMS";
            public const string SellPAS = "Sell PAS";
            public const string ActivatePAS = "Activate PAS";
            public const string ActivateBetaSMS = "Activate Beta SMS";
            public const string ActivateWelcomeMessage = "Activate Welcome Message";



        }

        public static class XPath_TicketDetails
        {
            public const string SchoolId1 = nameof(SchoolId1);
            public const string ddlschool1 = nameof(ddlschool1);
            public const string DioceseId = nameof(DioceseId);
            public const string ddldiocese = nameof(ddldiocese);
            public const string title = nameof(title);
            public const string description = nameof(description);
            public const string Status = nameof(Status);
            public const string category = nameof(category);
            public const string assignedto = nameof(assignedto);
            public const string priority = nameof(priority);
            public const string comments = nameof(comments);
            public const string ticketfile = nameof(ticketfile);

        }

        public static class XPath_UserDetails
        {
            public const string txtfirstname = nameof(txtfirstname);
            public const string txtlastname = nameof(txtlastname);
            public const string rolename = nameof(rolename);
            public const string txtemail = nameof(txtemail);
            public const string txtpassword = nameof(txtpassword);
            public const string Documentation = "staffDirectoryModel_Documentation";

        }
        public static class XPath_UserRole
        {
            public const string txtrolename = nameof(txtrolename);
            public const string txtdiscription = nameof(txtdiscription);
            public const string ddllandingpage = nameof(ddllandingpage);
            public const string btnRoleSave = "//button[@class='btn btn-success filter-btn']";
            public const string btnRoleCancel = "//a[@class='btn btn-secondary filter-btn']";


        
        }


            public static class XPath_SchoolListWorkLoad
        {
            public const string ddlDio = nameof(ddlDio);

        }
        public static class XPath_Customer
        {

            public const string mdRequestbtn = nameof(mdRequestbtn);
            public const string emailAddress = nameof(emailAddress);
            public const string CustomerSave = "//*[@class='btn btn-success text-center']";
            public const string CustomerCancel = "//*[@class='btn btn-secondary']";
            public const string CustomerDelete = "//*[@class='fa fa-trash']";



        }

        public static class XPath_Login
        {
            public const string username = nameof(username);
            public const string password = nameof(password);

        }

        public static class XPath_SystemMessage
        {
            public const string StartDate = nameof(StartDate);
            public const string EndDate = nameof(EndDate);
            public const string MessageTitle = nameof(MessageTitle);
        }




    }
}
