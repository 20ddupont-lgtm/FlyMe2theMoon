-- --------------------------------------------------------------------------------
-- Name: Daniel Dupont
 
-- Abstract: FlyMe2theMoon
-- --------------------------------------------------------------------------------

-- --------------------------------------------------------------------------------
-- Options
-- --------------------------------------------------------------------------------
USE dbFlyMe2theMoon;     
SET NOCOUNT ON;  

-- --------------------------------------------------------------------------------
--						Problem #10
-- --------------------------------------------------------------------------------

-- Drop Table Statements
IF OBJECT_ID ('TPilotFlights')						IS NOT NULL DROP TABLE TPilotFlights
IF OBJECT_ID ('TAttendantFlights')					IS NOT NULL DROP TABLE TAttendantFlights
IF OBJECT_ID ('TFlightPassengers')					IS NOT NULL DROP TABLE TFlightPassengers
IF OBJECT_ID ('TMaintenanceMaintenanceWorkers')		IS NOT NULL DROP TABLE TMaintenanceMaintenanceWorkers
IF OBJECT_ID ('TUserLogins')						IS NOT NULL DROP TABLE TUserLogins

IF OBJECT_ID ('TPassengers')			IS NOT NULL DROP TABLE TPassengers
IF OBJECT_ID ('TPilots')				IS NOT NULL DROP TABLE TPilots
IF OBJECT_ID ('TAttendants')			IS NOT NULL DROP TABLE TAttendants
IF OBJECT_ID ('TMaintenanceWorkers')	IS NOT NULL DROP TABLE TMaintenanceWorkers

IF OBJECT_ID ('TFlights')				IS NOT NULL DROP TABLE TFlights
IF OBJECT_ID ('TMaintenances')			IS NOT NULL DROP TABLE TMaintenances
IF OBJECT_ID ('TPlanes')				IS NOT NULL DROP TABLE TPlanes
IF OBJECT_ID ('TPlaneTypes')			IS NOT NULL DROP TABLE TPlaneTypes
IF OBJECT_ID ('TPilotRoles')			IS NOT NULL DROP TABLE TPilotRoles
IF OBJECT_ID ('TAirports')				IS NOT NULL DROP TABLE TAirports
IF OBJECT_ID ('TStates')				IS NOT NULL DROP TABLE TStates

-- --------------------------------------------------------------------------------
--	Step #1 : Create table 
-- --------------------------------------------------------------------------------

CREATE TABLE TPassengers
(
	 intPassengerID			INTEGER			NOT NULL
	,strFirstName			VARCHAR(255)	NOT NULL
	,strLastName			VARCHAR(255)	NOT NULL
	,strAddress				VARCHAR(255)	NOT NULL
	,strCity				VARCHAR(255)	NOT NULL
	,intStateID				INTEGER			NOT NULL
	,strZip					VARCHAR(255)	NOT NULL
	,strPhoneNumber			VARCHAR(255)	NOT NULL
	,strEmail				VARCHAR(255)	NOT NULL
	,CONSTRAINT TPassengers_PK PRIMARY KEY ( intPassengerID )
)


CREATE TABLE TPilots
(
	 intPilotID				INTEGER			NOT NULL
	,strFirstName			VARCHAR(255)	NOT NULL
	,strLastName			VARCHAR(255)	NOT NULL
	,strEmployeeID			VARCHAR(255)	NOT NULL
	,dtmDateOfHire			DATETIME		NOT NULL
	,dtmDateOfTermination	DATETIME		NOT NULL
	,dtmDateOfLicense		DATETIME		NOT NULL
	,intPilotRoleID			INTEGER			NOT NULL

	,CONSTRAINT TPilots_PK PRIMARY KEY ( intPilotID )
)


CREATE TABLE TAttendants
(
	 intAttendantID			INTEGER			NOT NULL
	,strFirstName			VARCHAR(255)	NOT NULL
	,strLastName			VARCHAR(255)	NOT NULL
	,strEmployeeID			VARCHAR(255)	NOT NULL
	,dtmDateOfHire			DATETIME		NOT NULL
	,dtmDateOfTermination	DATETIME		NOT NULL
	,CONSTRAINT TAttendants_PK PRIMARY KEY ( intAttendantID )
)


CREATE TABLE TMaintenanceWorkers
(
	 intMaintenanceWorkerID	INTEGER			NOT NULL
	,strFirstName			VARCHAR(255)	NOT NULL
	,strLastName			VARCHAR(255)	NOT NULL
	,strEmployeeID			VARCHAR(255)	NOT NULL
	,dtmDateOfHire			DATETIME		NOT NULL
	,dtmDateOfTermination	DATETIME		NOT NULL
	,dtmDateOfCertification	DATETIME		NOT NULL
	,CONSTRAINT TMaintenanceWorkers_PK PRIMARY KEY ( intMaintenanceWorkerID )
)


CREATE TABLE TStates
(
	 intStateID			INTEGER			NOT NULL
	,strState			VARCHAR(255)	NOT NULL
	,CONSTRAINT TStates_PK PRIMARY KEY ( intStateID )
)


CREATE TABLE TFlights
(
	 intFlightID			INTEGER			NOT NULL
	,strFlightNumber		VARCHAR(255)	NOT NULL
	,dtmFlightDate			DATETIME		NOT NULL
	,dtmTimeofDeparture		TIME			NOT NULL
	,dtmTimeOfLanding		TIME			NOT NULL
	,intFromAirportID		INTEGER			NOT NULL
	,intToAirportID			INTEGER			NOT NULL
	,intMilesFlown			INTEGER			NOT NULL
	,intPlaneID				INTEGER			NOT NULL
	,CONSTRAINT TFlights_PK PRIMARY KEY ( intFlightID )
)


CREATE TABLE TMaintenances
(
	 intMaintenanceID		INTEGER			NOT NULL
	,strWorkCompleted		VARCHAR(8000)	NOT NULL
	,dtmMaintenanceDate		DATETIME		NOT NULL
	,intPlaneID				INTEGER			NOT NULL
	,CONSTRAINT TMaintenances_PK PRIMARY KEY ( intMaintenanceID )
)


CREATE TABLE TPlanes
(
	 intPlaneID				INTEGER			NOT NULL
	,strPlaneNumber			VARCHAR(255)	NOT NULL
	,intPlaneTypeID			INTEGER			NOT NULL
	,CONSTRAINT TPlanes_PK PRIMARY KEY ( intPlaneID )
)


CREATE TABLE TPlaneTypes	
(
	 intPlaneTypeID			INTEGER			NOT NULL
	,strPlaneType			VARCHAR(255)	NOT NULL
	,CONSTRAINT TPlaneTypes_PK PRIMARY KEY ( intPlaneTypeID )
)


CREATE TABLE TPilotRoles	
(
	 intPilotRoleID			INTEGER			NOT NULL
	,strPilotRole			VARCHAR(255)	NOT NULL
	,CONSTRAINT TPilotRoles_PK PRIMARY KEY ( intPilotRoleID )
)


CREATE TABLE TAirports
(
	 intAirportID			INTEGER			NOT NULL
	,strAirportCity			VARCHAR(255)	NOT NULL
	,strAirportCode			VARCHAR(255)	NOT NULL
	,CONSTRAINT TAirports_PK PRIMARY KEY ( intAirportID )
)


CREATE TABLE TPilotFlights
(
	 intPilotFlightID		INTEGER			NOT NULL
	,intPilotID				INTEGER			NOT NULL
	,intFlightID			INTEGER			NOT NULL
	,CONSTRAINT TPilotFlights_PK PRIMARY KEY ( intPilotFlightID )
)


CREATE TABLE TAttendantFlights
(
	 intAttendantFlightID		INTEGER			NOT NULL
	,intAttendantID				INTEGER			NOT NULL
	,intFlightID				INTEGER			NOT NULL
	,CONSTRAINT TAttendantFlights_PK PRIMARY KEY ( intAttendantFlightID )
)


CREATE TABLE TFlightPassengers
(
	 intFlightPassengerID		INTEGER			NOT NULL
	,intFlightID				INTEGER			NOT NULL
	,intPassengerID				INTEGER			NOT NULL
	,strSeat					VARCHAR(255)	NOT NULL
	,CONSTRAINT TFlightPassengers_PK PRIMARY KEY ( intFlightPassengerID )
)


CREATE TABLE TMaintenanceMaintenanceWorkers
(
	 intMaintenanceMaintenanceWorkerID		INTEGER			NOT NULL
	,intMaintenanceID						INTEGER			NOT NULL
	,intMaintenanceWorkerID					INTEGER			NOT NULL
	,intHours								INTEGER			NOT NULL
	,CONSTRAINT TMaintenanceMaintenanceWorkers_PK PRIMARY KEY ( intMaintenanceMaintenanceWorkerID )
)

CREATE TABLE TUserLogins
(
     intUserLoginID    INTEGER       NOT NULL
    ,strUserName       VARCHAR(255)  NOT NULL
    ,strPassword       VARCHAR(255)  NOT NULL
    ,strRole           VARCHAR(50)   NOT NULL
    ,intUserID         INTEGER       NOT NULL
    ,CONSTRAINT TUserLogins_PK PRIMARY KEY (intUserLoginID)
); 

-- --------------------------------------------------------------------------------
--	Step #2 : Establish Referential Integrity 
-- --------------------------------------------------------------------------------
--
-- #	Child							Parent						Column
-- -	-----							------						---------
-- 1	TPassengers						TStates						intStateID	
-- 2	TFlightPassenger				TPassengers					intPassengerID
-- 3	TFlights						TPlanes						intPlaneID
-- 4	TFlights						TAirports					intFromAiportID
-- 5	TFlights						TAirports					intToAiportID
-- 6	TPilotFlights					TFlights					intFlightID
-- 7	TAttendantFlights				TFlights					intFlightID
-- 8	TPilotFlights					TPilots						intPilotID
-- 9	TAttendantFlights				TAttendants					intAttendantID
-- 10	TPilots							TPilotRoles					intPilotRoleID
-- 11	TPlanes							TPlaneTypes					intPlaneTypeID
-- 12	TMaintenances					TPlanes						intPlaneID
-- 13	TMaintenanceMaintenanceWorkers	TMaintenance				intMaintenanceID
-- 14	TMaintenanceMaintenanceWorkers	TMaintenanceWorker			intMaintenanceWorkerID
-- 15	TFlightPassenger				TFlights					intFlightID

--1
ALTER TABLE TPassengers ADD CONSTRAINT TPassengers_TStates_FK 
FOREIGN KEY ( intStateID ) REFERENCES TStates ( intStateID )

--2
ALTER TABLE TFlightPassengers ADD CONSTRAINT TPFlightPassengers_TPassengers_FK 
FOREIGN KEY ( intPassengerID ) REFERENCES TPassengers ( intPassengerID )

--3
ALTER TABLE TFlights	 ADD CONSTRAINT TFlights_TPlanes_FK 
FOREIGN KEY ( intPlaneID ) REFERENCES TPlanes ( intPlaneID )

--4
ALTER TABLE TFlights	 ADD CONSTRAINT TFlights_TFromAirports_FK 
FOREIGN KEY ( intFromAirportID ) REFERENCES TAirports ( intAirportID )

--5
ALTER TABLE TFlights	 ADD CONSTRAINT TFlights_TToAirports_FK 
FOREIGN KEY ( intToAirportID ) REFERENCES TAirports ( intAirportID )

--6
ALTER TABLE TPilotFlights	 ADD CONSTRAINT TPilotFlights_TFlights_FK 
FOREIGN KEY ( intFlightID ) REFERENCES TFlights (intFlightID )  

--7
ALTER TABLE TAttendantFlights	 ADD CONSTRAINT TAttendantFlights_TFlights_FK 
FOREIGN KEY ( intFlightID ) REFERENCES TFlights (intFlightID ) 

--8
ALTER TABLE TPilotFlights	 ADD CONSTRAINT TPilotFlights_TPilots_FK 
FOREIGN KEY ( intPilotID ) REFERENCES TPilots (intPilotID ) 

--9
ALTER TABLE TAttendantFlights	 ADD CONSTRAINT TAttendantFlights_TAttendants_FK 
FOREIGN KEY ( intAttendantID ) REFERENCES TAttendants (intAttendantID )

--10
ALTER TABLE TPilots	 ADD CONSTRAINT TPilots_TPilotRoles_FK 
FOREIGN KEY ( intPilotRoleID ) REFERENCES TPilotRoles (intPilotRoleID )  

--11
ALTER TABLE TPlanes	 ADD CONSTRAINT TPlanes_TPlaneTypes_FK 
FOREIGN KEY ( intPlaneTypeID ) REFERENCES TPlaneTypes (intPlaneTypeID )  

--12
ALTER TABLE TMaintenances	 ADD CONSTRAINT TMaintenances_TPlanes_FK 
FOREIGN KEY ( intPlaneID ) REFERENCES TPlanes (intPlaneID )  

--13
ALTER TABLE TMaintenanceMaintenanceWorkers	 ADD CONSTRAINT TMaintenanceMaintenanceWorkers_TMaintenances_FK 
FOREIGN KEY ( intMaintenanceID ) REFERENCES TMaintenances (intMaintenanceID ) 

--14
ALTER TABLE TMaintenanceMaintenanceWorkers	 ADD CONSTRAINT TMaintenanceMaintenanceWorkers_TMaintenanceWorkers_FK 
FOREIGN KEY ( intMaintenanceWorkerID ) REFERENCES TMaintenanceWorkers (intMaintenanceWorkerID ) 

--15
ALTER TABLE TFlightPassengers	 ADD CONSTRAINT TFlightPassengers_TFlights_FK 
FOREIGN KEY ( intFlightID ) REFERENCES TFlights (intFlightID ) 

-- --------------------------------------------------------------------------------
--	Step #3 : Add Data - INSERTS
-- --------------------------------------------------------------------------------
INSERT INTO TStates( intStateID, strState)
VALUES				(1, 'Ohio')
				   ,(2, 'Kentucky')
				   ,(3, 'Indiana')


INSERT INTO TPilotRoles( intPilotRoleID, strPilotRole)
VALUES				(1, 'Co-Pilot')
				   ,(2, 'Captain')

				
INSERT INTO TPlaneTypes( intPlaneTypeID, strPlaneType)
VALUES				(1, 'Airbus A350')
				   ,(2, 'Boeing 747-8')
				   ,(3, 'Boeing 767-300F')


INSERT INTO TPlanes( intPlaneID, strPlaneNumber, intPlaneTypeID)
VALUES				(1, '4X887G', 1)
				   ,(2, '5HT78F', 2)
				   ,(3, '5TYY65', 2)
				   ,(4, '4UR522', 1)
				   ,(5, '6OP3PK', 3)
				   ,(6, '67TYHH', 3)


INSERT INTO TAirports( intAirportID, strAirportCity, strAirportCode)
VALUES				(1, 'Cincinnati', 'CVG')
				   ,(2, 'Miami', 'MIA')
				   ,(3, 'Ft. Meyer', 'RSW')
				   ,(4, 'Louisville',  'SDF')
				   ,(5, 'Denver', 'DEN')
				   ,(6, 'Orlando', 'MCO' )


INSERT INTO TPassengers (intPassengerID, strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail)
VALUES				  (1, 'Knelly', 'Nervious', '321 Elm St.', 'Cincinnati', 1, '45201', '5135553333', 'nnelly@gmail.com')
					 ,(2, 'Orville', 'Waite', '987 Oak St.', 'Cleveland', 1, '45218', '5135556333', 'owright@gmail.com')
					 ,(3, 'Eileen', 'Awnewe', '1569 Windisch Rd.', 'Dayton', 1, '45069', '5135555333', 'eonewe1@yahoo.com')
					 ,(4, 'Bob', 'Eninocean', '44561 Oak Ave.', 'Florence', 2, '45246', '8596663333', 'bobenocean@gmail.com')
					 ,(5, 'Ware', 'Hyjeked', '44881 Pine Ave.', 'Aurora', 3, '45546', '2825553333', 'Hyjekedohmy@gmail.com')
					 ,(6, 'Kay', 'Oss', '4484 Bushfield Ave.', 'Lawrenceburg', 3, '45546', '2825553333', 'wehavekayoss@gmail.com')


INSERT INTO TPilots (intPilotID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination, dtmDateofLicense, intPilotRoleID)
VALUES				  (1, 'Tip', 'Seenow', '12121', '1/1/2015', '1/1/2099', '12/1/2014', 1)
					 ,(2, 'Ima', 'Soring', '13322', '1/1/2016', '1/1/2099', '12/1/2015', 1)
					 ,(3, 'Hugh', 'Encharge', '16666', '1/1/2017', '1/1/2099', '12/1/2016', 2)
					 ,(4, 'Iwanna', 'Knapp', '17676', '1/1/2014', '1/1/2015', '12/1/2013', 1)
					 ,(5, 'Rose', 'Ennair', '19909', '1/1/2012', '1/1/2099', '12/1/2011', 2)


INSERT INTO TAttendants (intAttendantID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination)
VALUES				  (1, 'Miller', 'Tyme', '22121', '1/1/2015', '1/1/2099')
					 ,(2, 'Sherley', 'Ujest', '23322', '1/1/2016', '1/1/2099')
					 ,(3, 'Buhh', 'Biy', '26666', '1/1/2017', '1/1/2099')
					 ,(4, 'Myles', 'Amanie', '27676', '1/1/2014', '1/1/2015')
					 ,(5, 'Walker', 'Toexet', '29909', '1/1/2012', '1/1/2099')


INSERT INTO TMaintenanceWorkers (intMaintenanceWorkerID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination, dtmDateOfCertification)
VALUES				  (1, 'Gressy', 'Nuckles', '32121', '1/1/2015', '1/1/2099', '12/1/2014')
					 ,(2, 'Bolt', 'Izamiss', '33322', '1/1/2016', '1/1/2099', '12/1/2015')
					 ,(3, 'Sharon', 'Urphood', '36666', '1/1/2017', '1/1/2099','12/1/2016')
					 ,(4, 'Ides', 'Racrozed', '37676', '1/1/2014', '1/1/2015','12/1/2013')
					

INSERT INTO TMaintenances (intMaintenanceID, strWorkCompleted, dtmMaintenanceDate, intPlaneID)
VALUES				  (1, 'Fixed Wing', '1/1/2022', 1)
					 ,(2, 'Repaired Flat Tire', '3/1/2022', 2)
					 ,(3, 'Added Wiper Fluid', '4/1/2022', 3)
					 ,(4, 'Tightened Engine to Wing', '5/1/2022', 2)
					 ,(5, '100,000 mile checkup', '3/10/2022', 4)
					 ,(6, 'Replaced Loose Door', '4/10/2022', 6)
					 ,(7, 'Trapped Raccoon in Cargo Hold', '5/1/2022', 6)


INSERT INTO TFlights (intFlightID, dtmFlightDate, strFlightNumber,  dtmTimeofDeparture, dtmTimeOfLanding, intFromAirportID, intToAirportID, intMilesFlown, intPlaneID)
VALUES				  (1, '4/1/2022', '111', '10:00:00', '12:00:00', 1, 2, 1200, 2)
					 ,(2, '4/4/2022', '222','13:00:00', '15:00:00', 1, 3, 1000, 2)
					 ,(3, '4/5/2022', '333','15:00:00', '17:00:00', 1, 5, 1200, 3)
					 ,(4, '4/16/2022','444', '10:00:00', '12:00:00', 4, 6, 1100, 3)
					 ,(5, '3/14/2022','555', '18:00:00', '20:00:00', 2, 1, 1200, 3)
					 ,(6, '3/21/2022','666', '19:00:00', '21:00:00', 3, 1, 1000, 1)
					 ,(7, '3/11/2022', '777','20:00:00', '22:00:00', 3, 6, 1400, 4)
					 ,(8, '3/17/2022', '888','09:00:00', '11:00:00', 6, 4, 1100, 5)
					 ,(9, '4/19/2022', '999','08:00:00', '10:00:00', 4, 2, 1000, 6)
					 ,(10, '4/22/2022', '091','10:00:00', '12:00:00', 2, 1, 1200, 6)
					 ,(11, '5/23/2027', '673','16:00:00', '18:00:00', 1, 5, 1200, 2)
					 ,(12, '5/24/2027', '418','13:00:00', '15:00:00', 1, 3, 1000, 4)


INSERT INTO TPilotFlights ( intPilotFlightID, intPilotID, intFlightID)
VALUES				 ( 1, 1, 2 )
					,( 2, 1, 3 )
					,( 3, 3, 3 )
					,( 4, 3, 2 )
					,( 5, 5, 1 )
					,( 6, 2, 1 )
					,( 7, 3, 4 )
					,( 8, 2, 4 )
					,( 9, 2, 5 )
					,( 10, 3, 5 )
					,( 11, 5, 6 )
					,( 12, 1, 6 )
					,( 13, 3, 11 )
					,( 14, 2, 11 )
					,( 15, 1, 12 )
					,( 16, 5, 12 )

INSERT INTO TAttendantFlights ( intAttendantFlightID, intAttendantID, intFlightID)
VALUES				 ( 1, 1, 2 )
					,( 2, 2, 3 )
					,( 3, 3, 3 )
					,( 4, 3, 2 )
					,( 5, 5, 1 )
					,( 6, 1, 1 )
					,( 7, 2, 4 )
					,( 8, 3, 4 )
					,( 9, 2, 5 )
					,( 10, 5, 5 )
					,( 11, 5, 6 )
					,( 12, 1, 6 )
					,( 13, 3, 11 )
					,( 14, 2, 11 )
					,( 15, 1, 12 )
					,( 16, 5, 12 )

INSERT INTO TFlightPassengers ( intFlightPassengerID, intFlightID, intPassengerID, strSeat)
VALUES				 ( 1, 1, 1, '1A')
					,( 2, 1, 2, '2A' )
					,( 3, 1, 3, '1B' )
					,( 4, 1, 4, '1C' )
					,( 5, 1, 5, '1D' )
					,( 6, 2, 5, '1A' )
					,( 7, 2, 4, '2A' )
					,( 8, 2, 3, '1B' )
					,( 9, 3, 1, '1B' )
					,( 10, 3, 2, '2A' )
					,( 11, 3, 3, '1B' )
					,( 12, 3, 4, '1C' )
					,( 13, 3, 5, '1D' )
					,( 14, 4, 2, '1A' )
					,( 15, 4, 3, '1B' )
					,( 16, 4, 4, '1C' )
					,( 17, 4, 5, '1D' )
					,( 18, 5, 1, '1A' )
					,( 19, 5, 2, '2A' )
					,( 20, 5, 3, '1B' )
					,( 21, 5, 4, '2B' )
					,( 22, 6, 1, '1A' )
					,( 23, 6, 2, '2A' )
					,( 24, 6, 3, '3A' )
					

INSERT INTO TMaintenanceMaintenanceWorkers ( intMaintenanceMaintenanceWorkerID, intMaintenanceID, intMaintenanceWorkerID, intHours)
VALUES				 ( 1, 2, 1, 2 )
					,( 2, 4, 1, 3 )
					,( 3, 2, 3, 4 )
					,( 4, 1, 4, 2 )
					,( 5, 3, 4, 2 )
					,( 6, 4, 3, 5 )
					,( 7, 5, 1, 7 )
					,( 8, 6, 1, 2 )
					,( 9, 7, 3, 4 )
					,( 10, 4, 4, 1 )
					,( 11, 3, 3, 4 )
					,( 12, 7, 3, 8 )

INSERT INTO TUserLogins (intUserLoginID, strUserName, strPassword, strRole, intUserID)
VALUES
     (1,  'knelly',      'cust1',   'Customer',  1)
    ,(2,  'orville',     'cust2',   'Customer',  2)
    ,(3,  'eileen',      'cust3',   'Customer',  3)
    ,(4,  'bob',         'cust4',   'Customer',  4)
    ,(5,  'ware',        'cust5',   'Customer',  5)
    ,(6,  'kay',         'cust6',   'Customer',  6)

    ,(7,  'tip',         'pilot1',  'Pilot',     1)
    ,(8,  'ima',         'pilot2',  'Pilot',     2)
    ,(9,  'hugh',        'pilot3',  'Pilot',     3)
    ,(10, 'iwanna',      'pilot4',  'Pilot',     4)
    ,(11, 'rose',        'pilot5',  'Pilot',     5)

    ,(12, 'miller',      'att1',    'Attendant', 1)
    ,(13, 'sherley',     'att2',    'Attendant', 2)
    ,(14, 'buhh',        'att3',    'Attendant', 3)
    ,(15, 'myles',       'att4',    'Attendant', 4)
    ,(16, 'walker',      'att5',    'Attendant', 5)

    ,(17, 'admin',       'admin1',   'Admin',    0);

SELECT * FROM TPassengers
SELECT * FROM TUserLogins
SELECT * FROM TPilots
SELECT * FROM TPilotFlights
SELECT * FROM TAttendants
SELECT * FROM TAttendantFlights
SELECT * FROM TFlights
SELECT * FROM TFlightPassengers

SELECT COUNT(intPassengerID) AS FlightAmount FROM TFlightPassengers
WHERE intPassengerID = 1

SELECT COUNT(strSeat) AS ReservedSeats FROM TFlightPassengers
WHERE strSeat = 'R' AND intFlightID = 12


SELECT intFlightID, 
       -- Combine Flight Number and Date into one string
       strFlightNumber + ' - ' + CAST(dtmFlightDate AS VARCHAR) AS FlightSummary, 
       dtmFlightDate, 
       strFlightNumber 
FROM TFlights


SELECT intFlightID, 
       (strFlightNumber + ' - ' + FORMAT(dtmFlightDate, 'MM/dd/yyyy')) AS FutureFlights
FROM TFlights 
WHERE dtmFlightDate > GETDATE()

SELECT intFlightID, 
       (strFlightNumber + ' - ' + FORMAT(dtmFlightDate, 'MM/dd/yyyy')) AS PastFlights
FROM TFlights 
WHERE dtmFlightDate < GETDATE()

GO
CREATE PROCEDURE uspGetPilotMilesFlown( @pilot_id AS INTEGER)
AS
BEGIN
	SELECT P.strFirstName, P.strLastName, F.intMilesFlown
	FROM TPilotFlights PF
	JOIN TPilots AS P
		ON PF.intPilotID = P.intPilotID
	JOIN TFlights AS F
		ON PF.intFlightID = F.intFlightID
	WHERE P.intPilotID = @pilot_id
END;
EXECUTE uspGetPilotMilesFlown 2;

GO
CREATE PROCEDURE uspSelectPilotByID( @pilot_id AS INTEGER)
AS
BEGIN
  SELECT TP.strFirstName, TP.strLastName, TP.strEmployeeID, TP.dtmDateofHire, TP.dtmDateofTermination, TP.dtmDateofLicense, TPR.intPilotRoleID, TPR.strPilotRole
   FROM TPilots AS TP

   JOIN TPilotRoles AS TPR
           ON TP.intPilotRoleID = TPR.intPilotRoleID 
   WHERE TP.intPilotID = @pilot_id

END;
EXECUTE uspSelectPilotByID 2;


GO
CREATE PROCEDURE uspSelectPilotPastFlights( @pilot_id AS INTEGER)
AS
BEGIN
	SELECT TF.dtmFlightDate, TF.strFlightNumber, TF.dtmTimeofDeparture, TF.dtmTimeOfLanding, TF.intFromAirportID, TF.intToAirportID, TF.intMilesFlown, TF.intPlaneID
	FROM TPilotFlights TPF

	JOIN TFlights AS TF
		ON TF.intFlightID = TPF.intFlightID
	JOIN TPilots AS TP
		ON TP.intPilotID = TPF.intPilotID

	WHERE TP.intPilotID = @pilot_id
		AND dtmFlightDate < GETDATE()
	ORDER BY dtmFlightDate ASC
END;
EXECUTE uspSelectPilotPastFlights 2;


GO
CREATE PROCEDURE uspSelectPilotPastMilesTotal( @pilot_id AS INTEGER)
AS
BEGIN
	SELECT SUM(TF.intMilesFlown) AS MilesFlown
	FROM TPilotFlights TPF
		JOIN TFlights AS TF
			ON TF.intFlightID = TPF.intFlightID
		JOIN TPilots AS TP
			ON TP.intPilotID = TPF.intPilotID

		WHERE TP.intPilotID = @pilot_id
			AND dtmFlightDate < GETDATE()

END;
EXECUTE uspSelectPilotPastMilesTotal 2;


GO
CREATE PROCEDURE uspSelectPilotFutureFlights( @pilot_id AS INTEGER)
AS
BEGIN
	SELECT TF.dtmFlightDate, TF.strFlightNumber, TF.intFromAirportID, TF.intToAirportID, TF.intPlaneID
	FROM TPilotFlights TPF

	JOIN TFlights AS TF
		ON TF.intFlightID = TPF.intFlightID
	JOIN TPilots AS TP
		ON TP.intPilotID = TPF.intPilotID

	WHERE TP.intPilotID = @pilot_id
		AND dtmFlightDate > GETDATE()
	ORDER BY dtmFlightDate ASC
END;
EXECUTE uspSelectPilotPastFlights 2;


GO
CREATE PROCEDURE uspInsertPilot
	 @pilot_id				INTEGER OUTPUT
	,@strFirstName			VARCHAR(50)
	,@strLastName			VARCHAR(50)
	,@strEmployeeID			VARCHAR(50)
	,@dtmDateofHire			DATE
	,@dtmDateofTermination	DATE
	,@dtmDateofLicense		DATE
	,@intPilotRoleID		INTEGER
AS
SET XACT_ABORT ON;
BEGIN TRANSACTION
	SELECT @pilot_id = MAX(intPilotID) + 1 FROM TPilots (TABLOCKX)
	SELECT @pilot_id = COALESCE(@pilot_id, 1)

	INSERT INTO TPilots (intPilotID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination, dtmDateofLicense, intPilotRoleID)
	VALUES (@pilot_id, @strFirstName, @strLastName, @strEmployeeID, @dtmDateofHire, @dtmDateofTermination, @dtmDateofLicense, @intPilotRoleID)

COMMIT TRANSACTION
GO


CREATE PROCEDURE uspUpdatePilot
 @intPilotID AS INTEGER
,@strFirstName AS VARCHAR(255)
,@strLastName AS VARCHAR(255)
,@strEmployeeID AS VARCHAR(255)
,@dtmDateofHire AS DATE
,@dtmDateofTermination AS DATE
,@dtmDateofLicense AS DATE
,@intPilotRoleID AS INTEGER

AS
SET XACT_ABORT ON -- terminate and rollback if any errors

BEGIN TRANSACTION

-- Update existing record
UPDATE TPilots
SET strFirstName = @strFirstName,
strLastName = @strLastName,
strEmployeeID = @strEmployeeID,
dtmDateofHire = @dtmDateofHire,
dtmDateOfTermination = @dtmDateofTermination,
dtmDateOfLicense = @dtmDateofLicense,
intPilotRoleID = @intPilotRoleID

WHERE intPilotID = @intPilotID

COMMIT TRANSACTION
GO


CREATE PROCEDURE uspDeletePilot
    @PilotID INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- 1. Delete child records first to satisfy FK constraint
		DELETE FROM TUserLogins
		WHERE intUserID = @PilotID
		AND strRole = 'Pilot'

        DELETE FROM TPilotFlights 
        WHERE intPilotID = @PilotID;

        -- 2. Delete the parent record
        DELETE FROM TPilots 
        WHERE intPilotID = @PilotID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        -- Re-throw error to be caught by VB.NET
        THROW;
    END CATCH
END;


GO
CREATE PROCEDURE uspInsertPilotFlightAssignment
	 @pilotflight_id		INTEGER OUTPUT
	,@intPilotID			INTEGER
	,@intFlightID			INTEGER

AS
SET XACT_ABORT ON;
BEGIN TRANSACTION
	SELECT @pilotflight_id = MAX(intPilotFlightID) + 1 FROM TPilotFlights (TABLOCKX)
	SELECT @pilotflight_id = COALESCE(@pilotflight_id, 1)

	INSERT INTO TPilotFlights (intPilotFlightID, intPilotID, intFlightID)
	VALUES (@pilotflight_id, @intPilotID, @intFlightID)

COMMIT TRANSACTION
GO



GO
CREATE PROCEDURE uspSelectCustomerPastMilesTotal( @passenger_id AS INTEGER)
AS
BEGIN
	SELECT SUM(TF.intMilesFlown) AS MilesFlown
	FROM TFlightPassengers TFP
		JOIN TFlights AS TF
			ON TF.intFlightID = TFP.intFlightID
		JOIN TPassengers AS TP
			ON TP.intPassengerID = TFP.intPassengerID

		WHERE TP.intPassengerID = @passenger_id
			AND dtmFlightDate < GETDATE()

END;
EXECUTE uspSelectCustomerPastMilesTotal 2;


GO
CREATE PROCEDURE uspSelectAttendantPastMilesTotal( @attendant_id AS INTEGER)
AS
BEGIN
	SELECT SUM(TF.intMilesFlown) AS MilesFlown
	FROM TAttendantFlights TAF
		JOIN TFlights AS TF
			ON TF.intFlightID = TAF.intFlightID
		JOIN TAttendants AS TA
			ON TA.intAttendantID = TAF.intAttendantID

		WHERE TA.intAttendantID = @attendant_id
			AND dtmFlightDate < GETDATE()

END;
EXECUTE uspSelectAttendantPastMilesTotal 2;

GO
CREATE PROCEDURE uspGetFlightReservedCount( @flight_id AS INTEGER)
AS
BEGIN
	SELECT COUNT(strSeat) AS ReservedSeats
	FROM TFlightPassengers
	WHERE strSeat = 'R'
	AND intFlightID = @flight_id
END;
EXECUTE uspGetFlightReservedCount 0;


GO
CREATE PROCEDURE uspUpdateAttendant
 @intAttendantID AS INTEGER
,@strFirstName AS VARCHAR(255)
,@strLastName AS VARCHAR(255)
,@strEmployeeID AS VARCHAR(255)
,@dtmDateofHire AS DATE
,@dtmDateofTermination AS DATE

AS
SET XACT_ABORT ON -- terminate and rollback if any errors

BEGIN TRANSACTION

-- Update existing record
UPDATE TAttendants
SET strFirstName = @strFirstName,
strLastName = @strLastName,
strEmployeeID = @strEmployeeID,
dtmDateofHire = @dtmDateofHire,
dtmDateOfTermination = @dtmDateofTermination

WHERE intAttendantID = @intAttendantID

COMMIT TRANSACTION

GO
CREATE PROCEDURE uspDeleteAttendant
    @AttendantID INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- 1. Delete child records first to satisfy FK constraint
		DELETE FROM TUserLogins
		WHERE intUserID = @AttendantID
		AND strRole = 'Attendant'

        DELETE FROM TAttendantFlights 
        WHERE intAttendantID = @AttendantID;

        -- 2. Delete the parent record
        DELETE FROM TAttendants
        WHERE intAttendantID = @AttendantID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        -- Re-throw error to be caught by VB.NET
        THROW;
    END CATCH
END;


--	-----------------------------------------
--			CREATE USER LOGINS
--	-----------------------------------------

GO
CREATE PROCEDURE uspInsertUserLogin
	 @userlogin_id			INTEGER OUTPUT
	,@strUserName			VARCHAR(50)
	,@strPassword			VARCHAR(50)
	,@strRole				VARCHAR(50)
	,@intUserID				INTEGER
AS
SET XACT_ABORT ON;
BEGIN TRANSACTION
	SELECT @userlogin_id = MAX(intUserLoginID) + 1 FROM TUserLogins (TABLOCKX)
	SELECT @userlogin_id = COALESCE(@userlogin_id, 1)

	SELECT @intUserID = MAX(intPassengerID) + 1 FROM TPassengers (TABLOCKX)
	SELECT @intUserID = COALESCE(@intUserID, 1)

	INSERT INTO TUserLogins (intUserLoginID, strUserName, strPassword, strRole, intUserID)
	VALUES (@userlogin_id, @strUserName, @strPassword, @strRole, @intUserID)

COMMIT TRANSACTION
GO

GO
CREATE PROCEDURE uspInsertPilotLogin
	 @userlogin_id			INTEGER OUTPUT
	,@strUserName			VARCHAR(50)
	,@strPassword			VARCHAR(50)
	,@strRole				VARCHAR(50)
	,@intUserID				INTEGER
AS
SET XACT_ABORT ON;
BEGIN TRANSACTION
	SELECT @userlogin_id = MAX(intUserLoginID) + 1 FROM TUserLogins (TABLOCKX)
	SELECT @userlogin_id = COALESCE(@userlogin_id, 1)

	SELECT @intUserID = MAX(intPilotID) FROM TPilots (TABLOCKX)
	SELECT @intUserID = COALESCE(@intUserID, 1)

	INSERT INTO TUserLogins (intUserLoginID, strUserName, strPassword, strRole, intUserID)
	VALUES (@userlogin_id, @strUserName, @strPassword, @strRole, @intUserID)

COMMIT TRANSACTION
GO

GO
CREATE PROCEDURE uspInsertAttendantLogin
	 @userlogin_id			INTEGER OUTPUT
	,@strUserName			VARCHAR(50)
	,@strPassword			VARCHAR(50)
	,@strRole				VARCHAR(50)
	,@intUserID				INTEGER
AS
SET XACT_ABORT ON;
BEGIN TRANSACTION
	SELECT @userlogin_id = MAX(intUserLoginID) + 1 FROM TUserLogins (TABLOCKX)
	SELECT @userlogin_id = COALESCE(@userlogin_id, 1)

	SELECT @intUserID = MAX(intAttendantID) FROM TAttendants (TABLOCKX)
	SELECT @intUserID = COALESCE(@intUserID, 0)

	INSERT INTO TUserLogins (intUserLoginID, strUserName, strPassword, strRole, intUserID)
	VALUES (@userlogin_id, @strUserName, @strPassword, @strRole, @intUserID)

COMMIT TRANSACTION
GO

--	-----------------------------------------
--					DELETES
--	-----------------------------------------

GO
CREATE PROCEDURE uspDeleteUserLogin
@intUserLoginID AS INTEGER

AS
SET XACT_ABORT ON -- terminate and rollback if any errors

BEGIN TRANSACTION

-- Delete record
DELETE FROM TUserLogins
WHERE intUserLoginID > 17

COMMIT TRANSACTION
GO


GO
CREATE PROCEDURE uspDeletePassenger
@intAttendantID AS INTEGER

AS
SET XACT_ABORT ON -- terminate and rollback if any errors

BEGIN TRANSACTION

-- Delete record
DELETE FROM TPassengers
WHERE intPassengerID > 6

COMMIT TRANSACTION
GO

--DELETE FROM TUserLogins
--WHERE intUserLoginID > 17

--DELETE FROM TFlightPassengers
--WHERE intFlightPassengerID > 24

--DELETE FROM TFlights
--WHERE intFlightID = 14

--DELETE FROM TPassengers
--WHERE intPassengerID > 6

--DELETE FROM TPilotFlights
--WHERE intPilotFlightID > 16

--DELETE FROM TPilots
--WHERE intPilotID > 5

--DELETE FROM TAttendantFlights
--WHERE intAttendantFlightID > 16

--DELETE FROM TAttendants
--WHERE intAttendantID > 5

SELECT * FROM TFlights
SELECT * FROM TAttendants
SELECT * FROM TPilots
SELECT * FROM TPassengers
SELECT * FROM TUserLogins