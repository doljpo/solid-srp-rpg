# 🧙‍♂️ SOLID RPG – Princípio SRP na Prática
![SOLID Principles](https://img.shields.io/badge/SOLID-Principles-blueviolet?style=for-the-badge&logo=codeforces)
![Single Responsibility Principle](https://img.shields.io/badge/SRP-Single%20Responsibility%20Principle-success?style=for-the-badge&logo=dotnet)
![Status](https://img.shields.io/badge/Status-Completo-brightgreen?style=for-the-badge&logo=github)

Este repositório demonstra na prática o **Princípio da Responsabilidade Única (SRP – Single Responsibility Principle)**, usando um cenário de criação de personagens em um jogo de RPG.

---

## 🧠 O que é SRP?

> “Uma classe deve ter apenas uma razão para mudar.”

Na prática, isso significa que cada classe deve ter uma **única responsabilidade** claramente definida. 
Ao seguir esse princípio, seu código se torna mais **modular, testável e de fácil manutenção**.

---

## 📂 Estrutura do Projeto

```text
/
├── Cenario_Ruim/           👎 Violação do SRP
│   └── Application/PersonagemService.cs
│   └── Domain/Personagem.cs
│
├── Cenario_Bom/            ✅ Aplicação correta do SRP
│   ├── Application/
│   │   └── PersonagemService.cs
│   ├── Domain/
│   │   ├── Personagem.cs
│   │   └── Atributos.cs
│   ├── Infrastructure/
│   │   ├── Repository/PersonagemRepository.cs
│   │   └── Services/NotificadorService.cs
│   └── Application/Interfaces/
│       ├── IPersonagemRepository.cs
│       └── INotificadorService.cs
```

---

## ❌ Cenário Ruim

O `PersonagemService` faz tudo:

- Valida entrada
- Cria personagem
- Define atributos
- Salva no “banco”
- Notifica o mestre

🔍 Isso viola o SRP porque a classe tem **várias razões para mudar**.

---

## ✅ Cenário Bom

Cada classe tem sua responsabilidade:

- `PersonagemService`: apenas **orquestra a criação**
- `Personagem`: valida e encapsula regras de negócio
- `Atributos`: define a lógica de atributos por classe
- `PersonagemRepository`: salva o personagem
- `NotificadorService`: envia notificações

---

## 🛠️ Executando

Este é um projeto console com .NET 6+.

```bash
dotnet run
```

---

## 🔄 Alternando entre os Cenários

O arquivo `Program.cs` já está preparado para que você possa **alternar entre os cenários Bom e Ruim** com apenas alguns comentários.

### ▶️ Por padrão:
- O código está rodando o cenário **bom**, que segue o princípio SRP corretamente.
- O cenário **ruim** está comentado.

### ✅ Para testar o cenário **bom** (já ativo):
```csharp
#region CENÁRIO BOM

using solid_srp_rpg.Cenario_Bom.Application;
using solid_srp_rpg.Cenario_Bom.Domain.Enums;
using Microsoft.Extensions.Hosting;
using solid_srp_rpg.Cenario_Bom.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
...
```

### ❌ Para testar o cenário **ruim**:
1. **Comente o trecho dentro da #region `CENÁRIO BOM`**
2. **Descomente o trecho dentro da #region `CENÁRIO RUIM`**, que usa o namespace `Cenario_Ruim`

```csharp
//#region CENÁRIO RUIM

//using solid_srp_rpg.Cenario_Ruim.Application;

//var personagemService = new PersonagemService();
...
```

💡 Assim você pode facilmente **comparar as abordagens**, debugar e entender como aplicar o **Single Responsibility Principle** na prática.

---

## ✍️ Autor

Feito por **David Putton** como demonstração prática de princípios SOLID.

---

## 📘 Licença

Uso livre para fins de estudo, demonstração e didática.
