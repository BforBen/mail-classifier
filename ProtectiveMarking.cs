using System;
using System.Collections.Generic;

namespace GuildfordBoroughCouncil.Mail
{
    public static class ProtectiveMarking
    {
        /// <summary>
        /// Returns a KeyValuePair for the appropriate Boldon James email header to mark as unclassified internal.
        /// </summary>
        public static KeyValuePair<string, string> UnclassifiedInternal = new KeyValuePair<string, string>("x-bjprotectivemarking", @"<?xml version=""1.0""?><sisl xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" sislVersion=""0"" policy=""b62b33be-a5f6-4f9d-86d0-ef32eac2404f"" xmlns=""http://www.boldonjames.com/2008/01/sie/internal/label""><element uid=""id_protective_marking_new_item_1"" value="""" /><element uid=""id_distribution_newvalue1"" value="""" /></sisl>");
        
        /// <summary>
        /// Returns a KeyValuePair for the appropriate Boldon James email header to mark as protected internal.
        /// </summary>
        public static KeyValuePair<string, string> ProtectedInternal = new KeyValuePair<string, string>("x-bjprotectivemarking", @"<?xml version=""1.0""?><sisl xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" sislVersion=""0"" policy=""b62b33be-a5f6-4f9d-86d0-ef32eac2404f"" xmlns=""http://www.boldonjames.com/2008/01/sie/internal/label""><element uid=""id_protective_marking_protect"" value="""" /><element uid=""id_distribution_newvalue1"" value="""" /></sisl>");

        /// <summary>
        /// Returns a KeyValuePair for the appropriate Boldon James email header to mark as restricted internal.
        /// </summary>
        public static KeyValuePair<string, string> RestrictedInternal = new KeyValuePair<string, string>("x-bjprotectivemarking", @"<?xml version=""1.0""?><sisl xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" sislVersion=""0"" policy=""b62b33be-a5f6-4f9d-86d0-ef32eac2404f"" xmlns=""http://www.boldonjames.com/2008/01/sie/internal/label""><element uid=""id_protective_marking_restricted"" value="""" /><element uid=""id_distribution_newvalue1"" value="""" /></sisl>");

        /// <summary>
        /// Returns a KeyValuePair for the appropriate Boldon James email header to mark as unclassified external.
        /// </summary>
        public static KeyValuePair<string, string> UnclassifiedExternal = new KeyValuePair<string, string>("x-bjprotectivemarking", @"<?xml version=""1.0""?><sisl xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" sislVersion=""0"" policy=""b62b33be-a5f6-4f9d-86d0-ef32eac2404f"" xmlns=""http://www.boldonjames.com/2008/01/sie/internal/label""><element uid=""id_protective_marking_new_item_1"" value="""" /><element uid=""id_distribution_external"" value="""" /></sisl>");

        /// <summary>
        /// Returns a KeyValuePair for the appropriate Boldon James email header to mark as protected external.
        /// </summary>
        public static KeyValuePair<string, string> ProtectedExternal = new KeyValuePair<string, string>("x-bjprotectivemarking", @"<?xml version=""1.0""?><sisl xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" sislVersion=""0"" policy=""b62b33be-a5f6-4f9d-86d0-ef32eac2404f"" xmlns=""http://www.boldonjames.com/2008/01/sie/internal/label""><element uid=""id_protective_marking_protect"" value="""" /><element uid=""id_distribution_external"" value="""" /></sisl>");
        
        /// <summary>
        /// Returns a KeyValuePair for the appropriate Boldon James email header to mark as restricted external.
        /// </summary>
        public static KeyValuePair<string, string> RestrictedExternal = new KeyValuePair<string, string>("x-bjprotectivemarking", @"<?xml version=""1.0""?><sisl xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" sislVersion=""0"" policy=""b62b33be-a5f6-4f9d-86d0-ef32eac2404f"" xmlns=""http://www.boldonjames.com/2008/01/sie/internal/label""><element uid=""id_protective_marking_restricted"" value="""" /><element uid=""id_distribution_external"" value="""" /></sisl>");
    }
}
