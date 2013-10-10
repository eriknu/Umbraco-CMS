﻿using System.Runtime.Serialization;

namespace Umbraco.Web.Models.ContentEditing
{
    /// <summary>
    /// A model representing the data required to set a member/user password depending on the provider installed.
    /// </summary>
    public class MemberPassword
    {
        /// <summary>
        /// The password value
        /// </summary>
        /// <remarks>
        /// This 
        /// </remarks>
        [DataMember(Name = "newPassword")]
        public string NewPassword { get; set; }

        /// <summary>
        /// The old password - used to change a password when: EnablePasswordRetrieval = false 
        /// </summary>
        [DataMember(Name = "oldPassword")]
        public string OldPassword { get; set; }

        /// <summary>
        /// Set to true if the password is to be reset - only valid when: EnablePasswordReset = true
        /// </summary>
        [DataMember(Name = "reset")]
        public bool? Reset { get; set; }

        /// <summary>
        /// The password answer - required for reset when: RequiresQuestionAndAnswer = true 
        /// </summary>
        [DataMember(Name = "answer")]
        public string Answer { get; set; }
    }
}