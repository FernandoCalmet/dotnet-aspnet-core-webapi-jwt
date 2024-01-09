# 🦄 C# ASP.NET Core API with JWT

[![Github][github-shield]][github-url]
[![Kofi][kofi-shield]][kofi-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
[![Khanakat][khanakat-shield]][khanakat-url]

## 🔥 ABOUT THE PROJECT
This project is a demonstration of JWT security using ASP.NET Core Web API with NET 8.

## ⚙️ INSTALLATION
Clone the repository.

```bash
gh repo clone FernandoCalmet/dotnet-aspnet-core-api-jwt
```

Data migration:

```bash
dotnet ef database update
```

Generate a new migration in the migrations directory:

```bash
dotnet ef migrations add InitialCreate --context ApplicationDbContext --output-dir Data/Migrations
```

## 📓 THEORETICAL OVERVIEW

### What is JWT? Why is it Important?
JWT, or JSON Web Token, is a compact, URL-safe means of representing claims to be transferred between two parties. The claims in a JWT are encoded as a JSON object that is used as the payload of a JSON Web Signature (JWS) structure or as the plaintext of a JSON Web Encryption (JWE) structure, enabling the claims to be digitally signed or integrity-protected with a Message Authentication Code (MAC) and/or encrypted.

JWTs are important in the context of web security for several reasons:

- **Authentication and Authorization**: JWTs are often used for authentication. Once the user logs in, a JWT is returned and must be saved client-side (usually in local storage). This token will be sent back to the server with every subsequent request, allowing the user to access routes, services, and resources permitted with that token.

- **Statelessness and Scalability**: Unlike traditional session-based authentication, which requires storing session data on the server, JWTs are self-contained and include all necessary information about the user. This makes them stateless; the server doesn't need to query the database on each request to authenticate the user. This stateless nature of JWTs allows for better scalability as it simplifies the server design.

- **Security**: When properly implemented, JWTs can provide a secure way to authenticate users and share information. They can be signed to ensure that the tokens haven't been tampered with. When using a private/public key pair, JWTs can be signed with the private key and verified with the corresponding public key, adding an extra layer of security.

- **Cross-Domain / CORS (Cross-Origin Resource Sharing)**: JWTs enable authorization in a cross-domain context, bypassing the same-origin policy limitations of web applications, making them suitable for Single Sign-On (SSO) contexts.

- **Ease of Use with RESTful APIs**: As RESTful APIs should be stateless, JWTs are an ideal fit for these scenarios, providing a robust method for representing user's credentials and privileges, making it easy to control and verify user access to resources.

JWTs are integral to modern web application security, providing a flexible, efficient means of handling authentication and information exchange. They are a key component in safeguarding communication between clients and servers, making them a cornerstone of secure application development in ASP.NET Core Web APIs.

## 📄 LICENSE
This project is under the MIT License - see the [LICENSE](LICENSE) file for more details.

## ⭐️ STAR THE PROJECT
If you found this implementation helpful or used it in your projects, consider giving it a star. Thank you! Or, if you're feeling extra generous, support the project with a [small contribution!](https://ko-fi.com/fernandocalmet).

<!--- reference style links --->
[github-shield]: https://img.shields.io/badge/-@fernandocalmet-%23181717?style=flat-square&logo=github
[github-url]: https://github.com/fernandocalmet
[kofi-shield]: https://img.shields.io/badge/-@fernandocalmet-%231DA1F2?style=flat-square&logo=kofi&logoColor=ff5f5f
[kofi-url]: https://ko-fi.com/fernandocalmet
[linkedin-shield]: https://img.shields.io/badge/-fernandocalmet-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/fernandocalmet
[linkedin-url]: https://www.linkedin.com/in/fernandocalmet
[khanakat-shield]: https://img.shields.io/badge/khanakat.com-brightgreen?style=flat-square
[khanakat-url]: https://khanakat.com
