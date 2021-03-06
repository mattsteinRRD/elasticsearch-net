﻿using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	[StringEnum]
	public enum Result
	{
		Error,

		[EnumMember(Value = "created")]
		Created,

		[EnumMember(Value = "updated")]
		Updated,

		[EnumMember(Value = "deleted")]
		Deleted,

		[EnumMember(Value = "not_found")]
		NotFound,

		[EnumMember(Value = "noop")]
		Noop
	}
}
