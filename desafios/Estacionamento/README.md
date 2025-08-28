<div>
    <h1 align="center">🚗 Estacionamento</h1>
</div>

<div align="center">
    <img width="100%" alt="img" src="https://www.zkteco.com.br/wp-content/uploads/2020/04/estacionamento-leitorUHF.png"/>
</div>

---

## Classes usadas

| Descrição | Caminho |
| -------- | -------- |
| Classe de interação com o usuário. | [🎲] [Program.cs](https://github.com/KawanSerafim/BOOTCAMP-Avanade-BackEnd-dotNET-IA/blob/main/desafios/Estacionamento/Program.cs) |
| Classe modelo do estacionamento. | [🎲] [Estacionamento.cs](https://github.com/KawanSerafim/BOOTCAMP-Avanade-BackEnd-dotNET-IA/blob/main/desafios/Estacionamento/Models/Estacionamento.cs) |

---

> [!NOTE]
> Abaixo o README é composto pela própria DIO. Nada meu foi escrito a partir daqui.

# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](./imagens/diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

---

## 📖 Guia de Leitura

| Descrição | Caminho |
| -------- | ----------- |
| [📑] Desafios | [🔗] [[./BOOTCAMP-Avanade-BackEnd-dotNET-IA/desafios]](https://github.com/KawanSerafim/BOOTCAMP-Avanade-BackEnd-dotNET-IA/blob/main/desafios/README.md) |
| [📑] Página principal | [🔗] [[./BOOTCAMP-Avanade-BackEnd-dotNET-IA]](https://github.com/KawanSerafim/BOOTCAMP-Avanade-BackEnd-dotNET-IA) |

---

## 🌐 Meus contatos

[![linkedin](https://img.icons8.com/color/60/linkedin.png)](https://www.linkedin.com/in/kawan-serafim/)
[![gmail](https://img.icons8.com/color/60/gmail-new.png)](mailto:kawanserafimdesouza@gmail.com)

