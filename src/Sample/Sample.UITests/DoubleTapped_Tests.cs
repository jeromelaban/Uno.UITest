﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Uno.UITest.Helpers.Queries;
using Uno.UITests.Helpers;

namespace Sample.UITests
{
	public class DoubleTapped_Tests : TestBase
	{
		[Test]
		public void DoubleTap()
		{
			App.WaitForElement("DoubleTapped 01");
			App.Tap("DoubleTapped 01");

			App.WaitForElement("TouchTarget");
			App.DoubleTap("TouchTarget");

			var result = App.Query(q => q.Marked("Result").GetDependencyPropertyValue("Text").Value<string>()).Single();

			Assert.AreEqual("Double tapped!", result);
		}
	}
}
