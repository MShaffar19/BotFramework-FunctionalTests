﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.BotFrameworkFunctionalTests.TeamsSkillBot
{
    public class SampleData
    {
        public SampleData()
        {
            MultiSelect = "true";
        }

        public string SubmitLocation { get; set; }

        public string Question { get; set; }

        public string MultiSelect { get; set; }

        public string Option1 { get; set; }

        public string Option2 { get; set; }

        public string Option3 { get; set; }
    }
}
