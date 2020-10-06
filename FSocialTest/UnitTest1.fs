module FSocialTest

open NUnit.Framework
open System

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    let x = Program.DaysInMonth
    Assert.AreEqual(30, x)

[<Test>]
let CoundDaysInMonths () =
    let x = Program.Months|> System.Linq.Enumerable.Sum
    Assert.AreEqual(365, x)

[<Test>]
let CheckLeapyear () = 
    Assert.True(Program.IsLeap(2000));
    Assert.True(Program.IsLeap(1984));
    Assert.False(Program.IsLeap(1700));
    Assert.False(Program.IsLeap(2001));
    Assert.False(Program.IsLeap(1986));
    Assert.False(Program.IsLeap(1800));
    Assert.False(Program.IsLeap(1900));
    Assert.False(Program.IsLeap(2100));
    Assert.False(Program.IsLeap(2200));
    Assert.False(Program.IsLeap(2300));
    Assert.False(Program.IsLeap(2500));
    Assert.False(Program.IsLeap(2600));

[<Test>]
let TestThis () =
    let x = Program.CalculateTwoArrays [1; 2; 3] [1; 2; 3]

    Assert.AreEqual([2;4;6], x)