--a)what was the branch that has no customer

    select * from Branch
    where Number not in(
        select b.Number from Customer c
        join Branch b
        on c.branch_no = b.Number)
 
--b)what was the branch that has no employee

    select * from Branch
    where Number not in(
        select b.Number from Employee e
        join Branch b
        on e.Branch_Number = b.Number)

--c)who was the employee with maximum number of loans added

    SELECT top 1 e.ID,e.Name ,count(l.Number) loan_num from Employee e
    join Loan l
    on l.Emp_ID = e.ID
    group by e.ID,e.Name 
    order by loan_num desc

--d)who were the customer(s) with maximum number of loans 

    SELECT c.ID,c.Name ,count(l.Number) loan_num from Customer c
    join Loan l
    on l.CustomerSSN = c.SSN
    group by c.ID,c.Name 
    having count(l.Number) in (
        SELECT top 1 count(l.Number) loan_num from Customer c
        join Loan l
        on l.CustomerSSN = c.SSN
        group by c.ID,c.Name 
        order by loan_num desc)

--e)who were the customer(s) who didnt take any loans

    select * from Customer where  SSN not in(
        select c.SSN from Customer c
        join Loan l
        on l.CustomerSSN=c.SSN
        )

--f)for each customer retrieve his information the number of employees he deals with

    select c.ID,c.SSN,c.Name,c.Address,c.Phone, 
    COUNT( distinct a.Emp_ID) account_emp, 
    COUNT( distinct l.Emp_ID) loan_emp, 
    COUNT(distinct e.ID ) total_emp from Customer c 
    left join Account a on a.CustomerSSN=c.SSN 
    left join Loan l on l.CustomerSSN=c.SSN 
    left join Employee e on a.Emp_ID = e.ID or l.Emp_ID = e.ID 
    group by c.ID,c.SSN,c.Name,c.Address,c.Phone


    