198
#181
(create) - API/Entities/Message.cs
(modify) - API/Entities/AppUser.cs
(modify) - API/Data/DataContext.cs

- dotnet ef migrations add MessageEntityAdded

#182
(create) - API/Interfaces/IMessageRepository.cs
(create) - API/DTOs/MessageDto.cs
(create) - API/Data/MessageRepository.cs
(modify) - API/Extensions/ApplicationServiceExtensions.cs

#183
(modify) - API/Helpers/AutoMapperProfiles.cs
(create) - API/DTOs/CreateMessageDto.cs

#184
(create) - API/Controllers/MessagesController.cs

#185
(modify) - API/Interfaces/IMessageRepository.cs
(create) - API/Helpers/MessageParams.cs
(modify) - API/Data/MessageRepository.cs
(modify) - API/Controllers/MessagesController.cs

#186
(modify) - API/Data/MessageRepository.cs
(modify) - API/Interfaces/IMessageRepository.cs
(modify) - API/Controllers/MessagesController.cs

#187
(create) - client/src/app/_models/message.ts
- ng g s _services/message
(create) - client/src/app/_services/message.service.ts
(modify) - client/src/app/_services/members.service.ts
(create) - client/src/app/_services/paginationHelper.ts
(modify) - client/src/app/messages/messages.component.ts
(modify) - client/src/app/messages/messages.component.html

#188
(modify) - client/src/app/messages/messages.component.html
(modify) - client/src/app/messages/messages.component.css

#189
(modify) - client/src/app/_services/message.service.ts
- ng g c members/member-messages
(create) - client/src/app/members/member-messages/member-messages.component.css
(create) - client/src/app/members/member-messages/member-messages.component.html
(create) - client/src/app/members/member-messages/member-messages.component.ts

(modify) - client/src/app/members/member-detail/member-detail.component.ts
(modify) - client/src/app/members/member-detail/member-detail.component.html
(remove) - client/src/app/app.module.ts (MemberMessageComponent)

#190
(modify) - client/src/app/members/member-messages/member-messages.component.html
(modify) - client/src/app/members/member-messages/member-messages.component.ts
(modify) - client/src/app/members/member-messages/member-messages.component.css

#191
(modify) - client/src/app/members/member-detail/member-detail.component.ts
(modify) - client/src/app/members/member-detail/member-detail.component.html

#192
(modify) - client/src/app/members/member-detail/member-detail.component.ts
(modify) - client/src/app/members/member-detail/member-detail.component.html
(modify) - client/src/app/members/member-card/member-card.component.html
(modify) - client/src/app/members/member-messages/member-messages.component.html

#193
ng g r _resolvers/member-detailed
(create) - client/src/app/_resolvers/member-detailed.resolver.ts
(modify) - client/src/app/app-routing.module.ts
(modify) - client/src/app/members/member-detail/member-detail.component.ts
(modify) - client/src/app/members/member-messages/member-messages.component.html

#194
(modify) - client/src/app/_services/message.service.ts
(modify) - client/src/app/members/member-messages/member-messages.component.ts
(modify) - client/src/app/members/member-messages/member-messages.component.html

#195
(modify) - client/src/app/messages/messages.component.ts
(modify) - client/src/app/messages/messages.component.html

#196
(modify) - API/Controllers/MessagesController.cs
(modify) - API/Data/MessageRepository.cs

#197
(modify) - client/src/app/_services/message.service.ts
(modify) - client/src/app/messages/messages.component.ts
(modify) - client/src/app/messages/messages.component.html
