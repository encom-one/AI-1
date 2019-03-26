﻿// https://docs.microsoft.com/en-us/visualstudio/modeling/t4-include-directive?view=vs-2017
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Bot.Builder.Solutions.Responses;

namespace VirtualAssistant.Dialogs.Main.Resources
{
    /// <summary>
    /// Contains bot responses.
    /// </summary>
    public class MainDialogResponses : IResponseIdCollection
    {
        // Generated accessors
        public const string NamePrompt = "NamePrompt";
        public const string HaveNameMessage = "HaveNameMessage";
        public const string NewUserGreetingTitle = "NewUserGreetingTitle";
        public const string NewUserGreetingBody = "NewUserGreetingBody";
        public const string Greeting = "Greeting";
        public const string ReturningUserGreetingTitle = "ReturningUserGreetingTitle";
        public const string ReturningUserGreetingBody = "ReturningUserGreetingBody";
    }
}