using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using MyCompany.Data;

namespace MyCompany.Rules
{
	public partial class CheckRequestsBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [ControllerAction("CheckRequests", "Insert", ActionPhase.Before)]
        [ControllerAction("CheckRequests", "Update", ActionPhase.Before)]
        public void AssignFieldValuesToCheckRequests(
                    int? chkreqID, 
                    string chkreqStatus, 
                    int? chkreqSendtoUserid, 
                    int? chkreqRequestedbyUserid, 
                    string chkreqPickup, 
                    int? chkreqReasonID, 
                    string chkreqOffice, 
                    decimal? chkreqAmount, 
                    string chkreqReasoncrReason, 
                    string chkreqJobno, 
                    int? chkreqApprovedbyUserid, 
                    DateTime? chkreqApproveddate, 
                    string chkreqToName, 
                    string chkreqToLine1, 
                    string chkreqToLine2, 
                    string chkreqtoLine3, 
                    string chkreqToCity, 
                    string chkreqToState, 
                    string chkreqToZipcode, 
                    DateTime? createdDate, 
                    DateTime? updatedDate, 
                    string employeeSearch)
        {
            var ChkreqPickupFieldValue = SelectFieldValueObject("ChkreqPickup");
            var ChkreqPickupCodeValue = 'P';
            if (ChkreqPickupFieldValue == null)
            	AddFieldValue("ChkreqPickup", ChkreqPickupCodeValue);
            else
            {
                ChkreqPickupFieldValue.NewValue = ChkreqPickupCodeValue;
                ChkreqPickupFieldValue.Modified = true;
                ChkreqPickupFieldValue.ReadOnly = false;
            }
        }
    }
}
