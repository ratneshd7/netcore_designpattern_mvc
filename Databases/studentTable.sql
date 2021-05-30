use swabhav;
CREATE TABLE student(
		stu_id int not null ,
		firstName varchar(20),
		lastname varchar(20));

INSERT INTO student(stu_id,firstName,lastname) values(1,'Ratnesh','Dubey');
INSERT INTO student(stu_id,firstName,lastname) values(2,'Onkar','Wala');
INSERT INTO student(stu_id,firstName,lastname) values(3,'Hiren','More');

select * from student;

CREATE TABLE merchant(
		merchant_id varchar(20) not null ,
		m_name varchar(20),
		m_balance int not null);

INSERT INTO merchant(merchant_id,m_name,m_balance) values('M01','Ratnesh',50000);
INSERT INTO merchant(merchant_id,m_name,m_balance) values('M02','Onkar',20000);
INSERT INTO merchant(merchant_id,m_name,m_balance) values('M03','Hiren',30000);

select * from merchant;
CREATE TABLE customer(
		customer_id varchar(20) not null ,
		c_name varchar(20),
		c_balance int not null);

INSERT INTO customer(customer_id,c_name,c_balance) values('C01','RDubey',50000);
INSERT INTO customer(customer_id,c_name,c_balance) values('C02','OnkarWalla',20000);
INSERT INTO customer(customer_id,c_name,c_balance) values('C03','HirenMore',30000);

select * from customer;

DROP TABLE EMP;
DROP TABLE DEPT;

CREATE TABLE DEPT (
 DEPTNO              integer NOT NULL,
 DNAME               varchar(14),
 LOC                 varchar(13),
 CONSTRAINT DEPT_PRIMARY_KEY PRIMARY KEY (DEPTNO));

INSERT INTO DEPT VALUES (10,'ACCOUNTING','NEW YORK');
INSERT INTO DEPT VALUES (20,'RESEARCH','DALLAS');
INSERT INTO DEPT VALUES (30,'SALES','CHICAGO');
INSERT INTO DEPT VALUES (40,'OPERATIONS','BOSTON');

CREATE TABLE EMP (
 EMPNO               integer NOT NULL,
 ENAME               varchar(10),
 JOB                 varchar(9),
 MGR                 integer CONSTRAINT EMP_SELF_KEY REFERENCES EMP (EMPNO),
 HIREDATE            DATEtime,
 SAL                 money,
 COMM                money,
 DEPTNO              integer NOT NULL,
 CONSTRAINT EMP_FOREIGN_KEY FOREIGN KEY (DEPTNO) REFERENCES DEPT (DEPTNO),
 CONSTRAINT EMP_PRIMARY_KEY PRIMARY KEY (EMPNO));

INSERT INTO EMP VALUES (7839,'KING','PRESIDENT',NULL,'17-NOV-81',5000,NULL,10);
INSERT INTO EMP VALUES (7698,'BLAKE','MANAGER',7839,'1-MAY-81',2850,NULL,30);
INSERT INTO EMP VALUES (7782,'CLARK','MANAGER',7839,'9-JUN-81',2450,NULL,10);
INSERT INTO EMP VALUES (7566,'JONES','MANAGER',7839,'2-APR-81',2975,NULL,20);
INSERT INTO EMP VALUES (7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30);
INSERT INTO EMP VALUES (7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30);
INSERT INTO EMP VALUES (7844,'TURNER','SALESMAN',7698,'8-SEP-81',1500,0,30);
INSERT INTO EMP VALUES (7900,'JAMES','CLERK',7698,'3-DEC-81',950,NULL,30);
INSERT INTO EMP VALUES (7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30);
INSERT INTO EMP VALUES (7902,'FORD','ANALYST',7566,'3-DEC-81',3000,NULL,20);
INSERT INTO EMP VALUES (7369,'SMITH','CLERK',7902,'17-DEC-80',800,NULL,20);
INSERT INTO EMP VALUES (7788,'SCOTT','ANALYST',7566,'09-DEC-82',3000,NULL,20);
INSERT INTO EMP VALUES (7876,'ADAMS','CLERK',7788,'12-JAN-83',1100,NULL,20);
INSERT INTO EMP VALUES (7934,'MILLER','CLERK',7782,'23-JAN-82',1300,NULL,10);


use  INDIA
go



CREATE TABLE REGIONS
    ( region_id      int 
       CONSTRAINT  region_id_nn NOT NULL , 
	   region_name    VARCHAR(25) 
    );


ALTER TABLE REGIONS
ADD CONSTRAINT reg_id_pk
    PRIMARY KEY (region_id);
     
     
CREATE TABLE COUNTRIES 
    ( COUNTRY_ID      CHAR(2) 
       CONSTRAINT  COUNTRY_ID_NN NOT NULL,
	   COUNTRY_NAME    VARCHAR(40),
	   REGION_ID       int, 
	   CONSTRAINT COUNTRY_C_ID_PK PRIMARY KEY (COUNTRY_ID) 
    ) 
    
    
    
ALTER TABLE COUNTRIES
ADD  CONSTRAINT COUNTR_REG_FK
     FOREIGN KEY (REGION_ID)
     REFERENCES REGIONS(REGION_ID) 

 
 CREATE TABLE LOCATIONS
    ( LOCATION_ID    int not null,
	 STREET_ADDRESS VARCHAR(40),
	 POSTAL_CODE    VARCHAR(12),
	 CITY       VARCHAR(30) CONSTRAINT     LOC_CITY_NN  NOT NULL,
	 STATE_PROVINCE VARCHAR(25), 
	 COUNTRY_ID     CHAR(2)
    ) ;
    
    
    
    
    ALTER TABLE LOCATIONS
ADD  CONSTRAINT LOC_ID_PK
                 PRIMARY KEY (LOCATION_ID)
    , CONSTRAINT LOC_C_ID_FK
                 FOREIGN KEY (COUNTRY_ID)
                  REFERENCES COUNTRIES(COUNTRY_ID) 
                  
                  
                  
                  
                  
                  
INSERT INTO regions VALUES( 1, 'Europe');
INSERT INTO regions VALUES( 2, 'Americas');
INSERT INTO regions VALUES( 3, 'Asia');
INSERT INTO regions VALUES( 4, 'Middle East and Africa');





INSERT INTO countries VALUES( 'IT', 'Italy', 1);
INSERT INTO countries VALUES( 'JP', 'Japan', 3);
INSERT INTO countries VALUES( 'US', 'United States of America', 2);
INSERT INTO countries VALUES( 'CA', 'Canada', 2);
INSERT INTO countries VALUES( 'CN', 'China', 3);
INSERT INTO countries VALUES( 'IN', 'India', 3);
INSERT INTO countries VALUES( 'AU', 'Australia', 3);
INSERT INTO countries VALUES( 'ZW', 'Zimbabwe',4);


INSERT INTO countries VALUES( 'SG', 'Singapore', 3);
INSERT INTO countries VALUES( 'UK', 'United Kingdom', 1);
INSERT INTO countries VALUES( 'FR', 'France', 1);
INSERT INTO countries VALUES( 'DE', 'Germany', 1);
INSERT INTO countries VALUES( 'ZM', 'Zambia', 4);
INSERT INTO countries VALUES( 'EG', 'Egypt', 4);
INSERT INTO countries VALUES( 'BR', 'Brazil', 2);
INSERT INTO countries VALUES( 'CH', 'Switzerland', 1);


INSERT INTO countries VALUES( 'NL', 'Netherlands', 1);
INSERT INTO countries VALUES( 'MX', 'Mexico', 2);
INSERT INTO countries VALUES( 'KW', 'Kuwait', 4);
INSERT INTO countries VALUES( 'IL', 'Israel', 4);
INSERT INTO countries VALUES( 'DK', 'Denmark', 1);
INSERT INTO countries VALUES( 'HK', 'HongKong', 3);
INSERT INTO countries VALUES( 'NG', 'Nigeria', 4);
INSERT INTO countries VALUES( 'AR', 'Argentina', 2);
INSERT INTO countries VALUES( 'BE', 'Belgium', 1);




INSERT INTO locations VALUES( 1000, '1297 Via Cola di Rie', '00989', 'Roma', NULL, 'IT');
INSERT INTO locations VALUES( 1100, '93091 Calle della Testa', '10934', 'Venice', NULL, 'IT');
INSERT INTO locations VALUES( 1200, '2017 Shinjuku-ku', '1689', 'Tokyo', 'Tokyo Prefecture', 'JP');
INSERT INTO locations VALUES( 1300, '9450 Kamiya-cho', '6823', 'Hiroshima', NULL, 'JP');
INSERT INTO locations VALUES( 1400, '2014 Jabberwocky Rd', '26192', 'Southlake', 'Texas', 'US');
INSERT INTO locations VALUES( 1500, '2011 Interiors Blvd', '99236', 'South San Francisco', 'California', 'US');
INSERT INTO locations VALUES( 1600, '2007 Zagora St', '50090', 'South Brunswick', 'New Jersey', 'US');
INSERT INTO locations VALUES( 1700, '2004 Charade Rd', '98199', 'Seattle', 'Washington', 'US');
INSERT INTO locations VALUES( 1800, '147 Spadina Ave', 'M5V 2L7', 'Toronto', 'Ontario', 'CA');
INSERT INTO locations VALUES( 1900, '6092 Boxwood St', 'YSW 9T2', 'Whitehorse', 'Yukon', 'CA');

select * from LOCATIONS;

