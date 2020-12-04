using System;
using System.Collections.Generic;

namespace net_core_hello.sakila
{
    public partial class CmineUsergroups
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int GroupQuota { get; set; }
        public byte HasAdminAccess { get; set; }
        public byte CanRatePictures { get; set; }
        public byte CanSendEcards { get; set; }
        public byte CanPostComments { get; set; }
        public byte CanUploadPictures { get; set; }
        public byte CanCreateAlbums { get; set; }
        public byte PubUplNeedApproval { get; set; }
        public byte PrivUplNeedApproval { get; set; }
        public byte AccessLevel { get; set; }
    }
}
