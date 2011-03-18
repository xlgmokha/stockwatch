﻿using System;
using gorilla.utility;

namespace solidware.financials.messages
{
    public class FamilyMemberToAdd : ValueType<FamilyMemberToAdd>
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime date_of_birth { get; set; }
    }
}