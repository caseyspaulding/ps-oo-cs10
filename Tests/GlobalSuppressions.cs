﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Assertion", "NUnit2015:Consider using Assert.That(actual, Is.SameAs(expected)) instead of Assert.AreSame(expected, actual)", Justification = "<Pending>", Scope = "member", Target = "~M:Tests.ImmutabilityTests.StringImmutabilityTests.Strings_are_immutable")]
[assembly: SuppressMessage("Assertion", "NUnit2006:Consider using Assert.That(actual, Is.Not.EqualTo(expected)) instead of Assert.AreNotEqual(expected, actual)", Justification = "<Pending>", Scope = "member", Target = "~M:Tests.ImmutabilityTests.StringImmutabilityTests.Strings_are_immutable")]
[assembly: SuppressMessage("Assertion", "NUnit2031:Consider using Assert.That(actual, Is.Not.SameAs(expected)) instead of Assert.AreNotSame(expected, actual)", Justification = "<Pending>", Scope = "member", Target = "~M:Tests.ImmutabilityTests.StringImmutabilityTests.Strings_are_immutable")]
