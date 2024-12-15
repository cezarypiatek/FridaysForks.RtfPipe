using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RtfPipe.Tests;

[TestClass]
public class TableTests
{
  [TestMethod]
  public void marge_scenario_1() => this.VerifyCurrentScenario();

  [TestMethod]
  public void marge_scenario_2() => this.VerifyCurrentScenario();

  [TestMethod]
  public void marge_scenario_3() => this.VerifyCurrentScenario();

  [TestMethod]
  public void marge_scenario_4() => this.VerifyCurrentScenario();

  [TestMethod]
  public void marge_scenario_5() => this.VerifyCurrentScenario();
  
  [TestMethod]
  public void marge_scenario_6() => this.VerifyCurrentScenario();
  
  [TestMethod]
  public void marge_scenario_7() => this.VerifyCurrentScenario();
  
  [TestMethod]
  public void table_with_object() => this.VerifyCurrentScenario();
}
