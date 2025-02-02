﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Fiap.Web.Ocorrencia.Testes.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class GerenciamentoDeVeiculosFeature : object, Xunit.IClassFixture<GerenciamentoDeVeiculosFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Veiculo.feature"
#line hidden
        
        public GerenciamentoDeVeiculosFeature(GerenciamentoDeVeiculosFeature.FixtureData fixtureData, Fiap_Web_Ocorrencia_Testes_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Gerenciamento de Veículos", "  Como um usuário,\r\n  Quero consultar e gerenciar os veículos disponíveis\r\n  Para" +
                    " garantir que estou recebendo informações corretas e que a API se comporta confo" +
                    "rme esperado", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Solicitar lista de veículos com sucesso")]
        [Xunit.TraitAttribute("FeatureTitle", "Gerenciamento de Veículos")]
        [Xunit.TraitAttribute("Description", "Solicitar lista de veículos com sucesso")]
        public void SolicitarListaDeVeiculosComSucesso()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Solicitar lista de veículos com sucesso", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
    testRunner.Given("que existem veículos cadastrados", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
    testRunner.When("eu faço uma solicitação de veículos GET para \"/api/veiculos\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
    testRunner.Then("o status da resposta de veículos deve ser 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 10
    testRunner.And("o corpo da resposta de veículos deve conter uma lista de veículos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
    testRunner.And("a lista de veículos deve conter duas entradas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
    testRunner.And("o contrato da resposta de veículos deve estar em conformidade com o JSON Schema \"" +
                        "veiculos-schema.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Solicitar lista de veículos sem nenhum registro")]
        [Xunit.TraitAttribute("FeatureTitle", "Gerenciamento de Veículos")]
        [Xunit.TraitAttribute("Description", "Solicitar lista de veículos sem nenhum registro")]
        public void SolicitarListaDeVeiculosSemNenhumRegistro()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Solicitar lista de veículos sem nenhum registro", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 14
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 15
    testRunner.Given("que não existem veículos cadastrados", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 16
    testRunner.When("eu faço uma solicitação de veículos GET para \"/api/veiculos\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
    testRunner.Then("o status da resposta de veículos deve ser 204", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
    testRunner.And("o corpo da resposta de veículos deve estar vazio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Solicitar veículo com ID inválido")]
        [Xunit.TraitAttribute("FeatureTitle", "Gerenciamento de Veículos")]
        [Xunit.TraitAttribute("Description", "Solicitar veículo com ID inválido")]
        public void SolicitarVeiculoComIDInvalido()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Solicitar veículo com ID inválido", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 20
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 21
    testRunner.Given("que o ID do veículo é inválido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 22
    testRunner.When("eu faço uma solicitação de veículos GET para \"/api/veiculos/{id_invalido}\" com o " +
                        "ID inválido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
    testRunner.Then("o status da resposta de veículos deve ser 400", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 24
    testRunner.And("o corpo da resposta de veículos deve conter uma mensagem de erro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                GerenciamentoDeVeiculosFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                GerenciamentoDeVeiculosFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
