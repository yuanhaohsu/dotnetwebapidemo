#219 - 236
    1. Use and set up SingalR on both the API and the client
    2. Implement online process
    3. Implement live chat between users

#220
(create) - API/SignalR/PresenceHub.cs
(modify) - API/Extensions/ApplicationServiceExtensions.cs
(modify) - API/Program.cs

#221
(modify) - API/SignalR/PresenceHub.cs
(modify) - API/Extensions/IdentityServiceExtensions.cs
(modify) - API/Program.cs

#222
https://www.npmjs.com/package/@microsoft/signalr 
- npm i @microsoft/signalr
(modify) - client/src/environments/environment.development.ts
(modify) - client/src/environments/environment.ts

- ng g s _services/presence
(create) - client/src/app/_services/presence.service.ts
(modify) - client/src/app/_services/account.service.ts

#223
(create) - API/SignalR/PresenceTracker.cs
(modify) - API/Extensions/ApplicationServiceExtensions.cs

#224
(modify) - client/src/app/_services/presence.service.ts
(modify) - client/src/app/members/member-card/member-card.component.ts
(modify) - client/src/app/members/member-card/member-card.component.html
(modify) - client/src/app/members/member-card/member-card.component.css
(modify) - client/src/app/members/member-detail/member-detail.component.html
(modify) - client/src/app/members/member-detail/member-detail.component.ts

#225
(create) - API/SignalR/MessageHub.cs
(modify) - API/Program.cs

#226
(modify) - API/SignalR/MessageHub.cs

#227
(modify) - client/src/app/_services/message.service.ts

#228
(modify) - client/src/app/members/member-detail/member-detail.component.html
(modify) - client/src/app/members/member-detail/member-detail.component.ts
(modify) - client/src/app/_services/message.service.ts
(modify) - client/src/app/members/member-messages/member-messages.component.ts
(modify) - client/src/app/members/member-messages/member-messages.component.html

#229
(modify) - client/src/app/_services/message.service.ts
(modify) - client/src/app/members/member-messages/member-messages.component.ts

#230
(create) - API/Entities/Group.cs
(create) - API/Entities/Connection.cs
(modify) - API/Interfaces/IMessageRepository.cs
(modify) - API/Data/MessageRepository.cs
- dotnet ef migrations add GroupAdded

#231
(modify) - API/SignalR/MessageHub.cs
(modify) - client/src/app/members/member-messages/member-messages.component.html
(modify) - API/Helpers/AutoMapperProfiles.cs

#232
(create) - PresenceHub.ts

#233
(modify) - API/SignalR/PresenceTracker.cs
(modify) - API/SignalR/MessageHub.cs
(modify) - presence.service.ts
(modify) - member-detail.component.ts
(create) - client/src/app/_services/customRouteReuseStrategy.ts
(modify) - app.module.ts

#234
(modify) - PresenceHub.cs
(modify) - PresenceTracker.cs
(modify) - presence.service.ts

#235
(modify) - MessageRepository.cs
(modify) - MessageHub.cs
(modify) - IMessageRepository.cs
(create) - client/src/app/_models/group.ts
(modify) - message.service.ts
