﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using T4TS.Tests.Utils;

namespace T4TS.Tests.Fixtures.Options.Default
{
    [TestClass]
    public class DefaultModuleTest
    {
        [TestMethod]
        public void DefaultModuleSettingHasExpectedOutput()
        {
            // Expect
            new OutputFor(
                typeof(DefaultModuleModel),
                typeof(DefaultModuleOverrideModel)
            ).With(new Settings {
                DefaultModule = "Foobar"
            }).ToEqual(ExpectedOutput);
        }

const string ExpectedOutput = @"
/****************************************************************************
  Generated by T4TS.tt - don't make any changes in this file
****************************************************************************/

declare module Foobar {
    /** Generated from T4TS.Tests.Fixtures.Options.Default.DefaultModuleModel **/
    export interface DefaultModuleModel {
        SomeProp: string;
    }
}

declare module Override {
    /** Generated from T4TS.Tests.Fixtures.Options.Default.DefaultModuleOverrideModel **/
    export interface DefaultModuleOverrideModel {
        SomeProp: string;
    }
}
";
    }
}