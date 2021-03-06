﻿using System;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Core.ManagedElasticsearch.Clusters;
using Tests.Domain;
using Tests.Framework.EndpointTests.TestState;

namespace Tests.Mapping.Types.Specialized.ConstantKeyword
{
	[SkipVersion("<7.7.0", "introduced in 7.7.0")]
	public class ConstantKeywordPropertyTests : PropertyTestsBase
	{
		public ConstantKeywordPropertyTests(WritableCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override object ExpectJson => new
		{
			properties = new
			{
				versionControl = new
				{
					type = "constant_keyword",
					value = Project.VersionControlConstant,
				}
			}
		};

		protected override Func<PropertiesDescriptor<Project>, IPromise<IProperties>> FluentProperties => f => f
			.ConstantKeyword(s => s
				.Name(n => n.VersionControl)
				.Value(Project.VersionControlConstant)
			);

		protected override IProperties InitializerProperties => new Properties
		{
			{
				"versionControl", new ConstantKeywordProperty
				{
					Value = Project.VersionControlConstant
				}
			}
		};
	}
}
