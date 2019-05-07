namespace MyCompany.Handlers
{
    
    
    public partial class BlobFactoryConfig : BlobFactory
    {
        
        public static void Initialize()
        {
            // register blob handlers
            RegisterHandler("CheckRequests_AttachmentsAttachment", "\"dbo\".\"CheckRequests_Attachments\"", "\"Attachment\"", new string[] {
                        "\"id\""}, "Checkrequests Attachments Attachment", "CheckrequestsAttachments", "Attachment");
            RegisterHandler("SiteContentData", "\"dbo\".\"SiteContent\"", "\"Data\"", new string[] {
                        "\"SiteContentID\""}, "Site Content Data", "SiteContent", "Data");
        }
    }
}
