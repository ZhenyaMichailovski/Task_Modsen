
insert into dbo.[Places](Title, Address, Description)
values('Stark tower', '890 Fifth Avenue, Manhattan, New York', 'A large building with the Avengers logo')

insert into dbo.[Organizers](Name, TypeOfActivity)
values('Tony Stark', 'Hmm… Genius, billionaire, playboy, philanthropist')

insert into dbo.[Events](Title, PlaceId, Description, TimeOfEvent)
values('Avengers Assemble', 1, 'The Avengers are going to their favorite place', '2022-04-11 20:13:25')

insert into dbo.[EventOrganizers](EventId, OrdanizerId)
values(1, 1)




