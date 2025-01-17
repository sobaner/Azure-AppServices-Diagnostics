﻿namespace Diagnostics.ModelsAndUtils.Attributes
{
    /// <summary>
    /// Enum representing Resource type or collection of Resource Types
    /// </summary>
    public enum ResourceType
    {
        /// <summary>
        /// App Resource
        /// </summary>
        App = 1,

        /// <summary>
        /// Hosting Environment Resource
        /// </summary>
        HostingEnvironment = 2,

        /// <summary>
        /// App Service Certificate Resource
        /// </summary>
        AppServiceCertificate = 4,

        /// <summary>
        /// App Service Domain Resource
        /// </summary>
        AppServiceDomain = 8,

        /// <summary>
        /// Logic App Resource
        /// </summary>
        LogicApp = 16,

        /// <summary>
        /// Api Management Service Resource
        /// </summary>
        ApiManagementService = 32,

        /// <summary>
        /// Azure Kubernetes Service Resource
        /// </summary>
        AzureKubernetesService = 64,

        /// <summary>
        /// Generic ARM Resource
        /// </summary>
        ArmResource = 128,

        /// <summary>
        /// Worker App Resource
        /// </summary>
        WorkerApp = 256
    }

    /// <summary>
    /// Enum reprensenting Platform type.
    /// </summary>
    public enum PlatformType
    {
        /// <summary>
        /// Reprensents windows platform
        /// </summary>
        Windows = 1,

        /// <summary>
        /// Represents linux platform
        /// </summary>
        Linux = 2,

        /// <summary>
        /// Represents HyperV platform
        /// </summary>
        HyperV = 4,

        /// <summary>
        /// Represents Kubernetes platform
        /// </summary>
        Kubernetes = 8
    }

    /// <summary>
    /// Represents different App Types
    /// </summary>
    public enum AppType
    {
        WebApp = 1,
        FunctionApp = 2,
        ApiApp = 4,
        MobileApp = 8,
        GatewayApp = 16,
        WorkflowApp = 32,
        All = 255
    }

    /// <summary>
    /// Hosting Environment Types
    /// </summary>
    public enum HostingEnvironmentType
    {
        None = 0,
        V1 = 1,
        V2 = 2,
        V3 = 4,
        K8SE = 8,
        All = 255
    }

    public enum StackType
    {
        None = 0,
        AspNet = 1,
        NetCore = 2,
        Php = 4,
        Python = 8,
        Node = 16,
        Java = 32,
        Static = 64,
        Sitecore = 128,
        Other = 256,
        All = 511
    }

    public enum SkuType
    {
        Free = 1,
        Shared = 2,
        Standard = 4,
        Premium = 8,
        All = 255
    }

    public enum StampType
    {
        Public = 1,
        ASEV1 = 2,
        ASEV2 = 4,
        K8SE = 8,
        All = 255
    }
}
