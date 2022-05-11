using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OrientacaoAObjetos;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.Tópicos_Avançados;


namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritimeticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadorAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternários - Fundamentos", OperadoresTernarios.Executar},
                
                // Estruturas de Controle
                {"Estrutura if - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura if / else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura if / else / if - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura while - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura do while - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura for - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura foreach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},
                
                //Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributos  - Classes e Métodos", DesafioAtributo.Executar},
                {"Params  - Classes e Métodos", Params.Executar},
                {"Parâmetros Nomeados  - Classes e Métodos", ParamentrosNomeados.Executar},
                {"Get e Set  - Classes e Métodos", GetSet.Executar},
                {"Props  - Classes e Métodos", Props.Executar},
                {"ReadOnly  - Classes e Métodos", ReadOnly.Executar},
                {"Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct Vs Classes - Classes e Métodos", StructVsClasses.Executar},
                {"Valor Vs Referencia - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros por Referencia - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetros Padrão - Classes e Métodos", ParamentroPadrao.Executar},
                
                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue (fila) - Coleções", ColecoesQueue.Executar},
                {"Igualdade (Equals e GetHashCode) - Coleções", Igualdade.Executar},
                {"Stack (pilha) - Coleções", ColecoesStack.Executar},
                {"Dicionário - Coleções", ColecoesDictionary.Executar},

                //Orientação a Objetos
                {"Herança - Orientação a Objetos", Heranca.Executar},
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a Objetos", OrientacaoAObjetos.Encapsulamento.Executar},
                {"Polimorfismo - Orientação a Objetos", Polimorfismo.Executar},
                {"Abstração - Orientação a Objetos", Abstract.Executar},
                {"Interface - Orientação a Objetos", Interface.Executar},
                {"Classe Selada (Sealed) - Orientação a Objetos", Sealed.Executar},

                //Métodos e Funções
                {"Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Delegate - Métodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegate - Métodos e Funções", UsandoDelegate.Executar},
                {"Delegates com Funções Anonimas - Métodos e Funções", DelegateFuncaoAnonima.Executar},
                {"Delegates como Parâmetros - Métodos e Funções", DelegatesComoParametro.Executar},
                {"Métodos e Extensão - Métodos e Funções", MetodosDeExtensao.Executar},

                //Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                {"Exceções Pernalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                //API
                {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo Arquivo - Usando API", LendoArquivos.Executar},
                {"Exemplo de File Info - Usando API", ExemploFileInfo.Executar},
                {"Diretórios - Usando API", Diretorios.Executar},
                {"Exemplos Directory Info - Usando API", ExemploDirectoryInfo.Executar},
                {"Exemplos Path - Usando API", ExemploPath.Executar},
                {"Exemplos Datetime - Usando API", ExemploDateTime.Executar},
                {"Exemplos TimeSpan - Usando API", ExemploTimeSpan.Executar},

                //Tópicos Avançados
                {"LINQ #01 - Tópicos Avançados", LINQ1.Executar},
                {"LINQ #02 - Tópicos Avançados", LINQ2.Executar},
                {"Nullables - Tópicos Avançados", Nullables.Executar},
                {"Dynamics - Tópicos Avançados", Dynamics.Executar},
                {"Genéricos - Tópicos Avançados", Genericos.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}