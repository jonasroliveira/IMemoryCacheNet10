# 🎯 IMemoryCache com .NET 10 e Scalar 

API desenvolvida em **ASP.NET Core (.NET 10)** que consome uma API externa de jogos (https://www.freetogame.com/api/) e utiliza **IMemoryCache** para otimizar consultas, seguindo boas práticas de **Clean Architecture** e **CQRS (Query Side)**.

---

## 🚀 Objetivo do Projeto

Demonstrar o uso correto de **cache em memória (`IMemoryCache`)** aplicado **somente para leitura**, reduzindo chamadas desnecessárias a uma API externa e melhorando performance e tempo de resposta.

O projeto foca em:
- Separação de responsabilidades
- Baixo acoplamento
- Código simples e evolutivo
- Padrões modernos do .NET

---

## 🧠 Conceitos Aplicados

- ✅ ASP.NET Core (.NET 10)
- ✅ IMemoryCache
- ✅ CQRS (somente Query / Read Side)
- ✅ Clean Architecture (Domain / Services / Infrastructure)
- ✅ Dependency Injection
- ✅ HttpClientFactory
- ✅ DTOs
- ✅ Interfaces para desacoplamento

### 🧩 Cache Strategy

Chave: GamesList_Key

Absolute Expiration: 1 hora

Sliding Expiration: 20 minutos

Cache armazenado como IReadOnlyList<T>

#### 📌 O cache é utilizado somente no lado de consulta (CQRS).

#### ▶️ Como Executar o Projeto

VS Code { dotnet run }

#### 🏗️ Quando usar IMemoryCache?

APIs com uma única instância

Dados que mudam pouco

Muitas leituras

❗ Para múltiplas instâncias ou Kubernetes, recomenda-se evoluir para Redis (IDistributedCache).


#### 📑 Endereço da Scalar local
 
http://localhost:5034/scalar/v1

### 👤 Autor
Jonas da Rosa Oliveira
