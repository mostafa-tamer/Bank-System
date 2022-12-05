--create database Banks;

use Banks;

create table Admin(

    ID int identity(1122,1),
    Name varchar(35),
    Password varchar(20),

    --Primary Keys
    constraint admin_pk primary key(ID)

);

create table Bank( 

    code int identity(1122,1),
    Name varchar(50),
	Address varchar(50),
    Admin_ID int
	
	--Primary Keys
	constraint bank_pk primary key (code),

    --Foreign Keys
    constraint bank_admin_fk foreign key (Admin_ID) references Admin(ID)

);

create table Branch(
	
	Number int Identity(11223,1),
	Address varchar(50),
	Bank_Code int,
    Admin_ID int,
	
	--Primary Keys
	constraint branch_pk primary key (Number),
	
	--Foreign Keys
	constraint branch_bank_fk foreign key (Bank_Code) references Bank(code),
    constraint branch_admin_fk foreign key (Admin_ID) references Admin(ID)

);

create table Employee(

	ID int identity(11223,1),
	Name varchar(80),
	Branch_Number int,
    Password varchar(20),

	--Primary Keys
	constraint employee_pk primary key (ID),
	
	--Foreign Keys
	constraint employee_branch_fk foreign key (Branch_Number) references Branch(Number)
);

create table Customer(
	ID int identity(112233,1),
	SSN int ,
	Name varchar(50),
	Phone varchar(11),
	Address varchar(50),
    Password varchar(20),
	branch_no int,
	--Primary Keys
	constraint customer_pk primary key (SSN)
	--froeign keys
	constraint Customer_branch_fk foreign key (branch_no) references Branch(Number)

);

create table Account(
	Number int identity(11223344,1),
	Type varchar(20), 
	Balance float,
	Emp_ID int,
	CustomerSSN int,
	
	--Primary Keys
	constraint account_pk primary key(Number),
	
	--Foreign Keys
	constraint account_employee_fk foreign key (Emp_ID) references Employee(ID),
	constraint account_customer_fk foreign key (CustomerSSN) references Customer(SSN),

);

create table Loan (

	Number int identity(1122,1),
	Amount float,
	Type varchar(20),
	Emp_ID int,
	CustomerSSN int,
	_status int,
	constraint check_bool check (_status in (1,0)),

	--Primary Keys
	constraint loan_pk primary key(Number),
	
	--Foreign Keys
	constraint loan_employee_fk foreign key(Emp_ID) references Employee(ID),
	constraint loan_customer_fk foreign key(CustomerSSN) references Customer(SSN)
);