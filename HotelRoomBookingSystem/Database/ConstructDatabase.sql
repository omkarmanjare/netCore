Create Database RoomBooking
GO

Create Table Room (
RoomId int Identity(1001,1) NOT NULL,
RoomType varchar(15) NOT NULL,
RoomNumber int NOT NULL,
RoomAvaibility bit
)
