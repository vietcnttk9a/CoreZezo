﻿using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PMS
{
    [DependsOn(typeof(PMSXamarinSharedModule))]
    public class PMSXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PMSXamarinAndroidModule).GetAssembly());
        }
    }
}