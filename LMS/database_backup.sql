--
-- PostgreSQL database dump
--

-- Dumped from database version 16.1
-- Dumped by pg_dump version 16.1

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: admins; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.admins (
    adminid integer NOT NULL,
    name character varying(50) NOT NULL,
    salt character varying(100) NOT NULL,
    password character varying(100) NOT NULL,
    email character varying(50) NOT NULL
);


ALTER TABLE public.admins OWNER TO postgres;

--
-- Name: authors; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.authors (
    authorid integer NOT NULL,
    author_name character varying(50),
    birth_date date
);


ALTER TABLE public.authors OWNER TO postgres;

--
-- Name: authors_authorid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.authors_authorid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.authors_authorid_seq OWNER TO postgres;

--
-- Name: authors_authorid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.authors_authorid_seq OWNED BY public.authors.authorid;


--
-- Name: books; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.books (
    bookid integer NOT NULL,
    title character varying(50),
    isbn character varying(20),
    genre character varying(50),
    published_date date,
    format character varying(20),
    file_path text,
    isvalid character varying(20),
    authorname character varying(50)
);


ALTER TABLE public.books OWNER TO postgres;

--
-- Name: books_bookid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.books_bookid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.books_bookid_seq OWNER TO postgres;

--
-- Name: books_bookid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.books_bookid_seq OWNED BY public.books.bookid;


--
-- Name: configurations; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.configurations (
    maxloantime integer NOT NULL,
    maxloannumber integer,
    finedefault integer
);


ALTER TABLE public.configurations OWNER TO postgres;

--
-- Name: employee; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.employee (
    employeeid integer NOT NULL,
    name character varying(50),
    status character varying(20),
    email character varying(50),
    phone character varying(20),
    password character varying(50),
    salt character varying(100)
);


ALTER TABLE public.employee OWNER TO postgres;

--
-- Name: employee_employeeid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.employee_employeeid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.employee_employeeid_seq OWNER TO postgres;

--
-- Name: employee_employeeid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.employee_employeeid_seq OWNED BY public.employee.employeeid;


--
-- Name: members; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.members (
    memberid integer NOT NULL,
    name character varying(50),
    email character varying(50),
    phone character varying(20),
    fine integer,
    password character varying(50),
    salt character varying(100)
);


ALTER TABLE public.members OWNER TO postgres;

--
-- Name: members_memberid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.members_memberid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.members_memberid_seq OWNER TO postgres;

--
-- Name: members_memberid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.members_memberid_seq OWNED BY public.members.memberid;


--
-- Name: reports; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.reports (
    reportid integer NOT NULL,
    description text,
    bookid integer,
    memberid integer
);


ALTER TABLE public.reports OWNER TO postgres;

--
-- Name: reports_reportid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.reports_reportid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.reports_reportid_seq OWNER TO postgres;

--
-- Name: reports_reportid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.reports_reportid_seq OWNED BY public.reports.reportid;


--
-- Name: transactions; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.transactions (
    transactionid integer NOT NULL,
    memberid integer,
    bookid integer,
    borrow_date date,
    return_date date,
    status character varying(20),
    userveiw character varying(200)
);


ALTER TABLE public.transactions OWNER TO postgres;

--
-- Name: transactions_transactionid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.transactions_transactionid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.transactions_transactionid_seq OWNER TO postgres;

--
-- Name: transactions_transactionid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.transactions_transactionid_seq OWNED BY public.transactions.transactionid;


--
-- Name: authors authorid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.authors ALTER COLUMN authorid SET DEFAULT nextval('public.authors_authorid_seq'::regclass);


--
-- Name: books bookid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.books ALTER COLUMN bookid SET DEFAULT nextval('public.books_bookid_seq'::regclass);


--
-- Name: employee employeeid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.employee ALTER COLUMN employeeid SET DEFAULT nextval('public.employee_employeeid_seq'::regclass);


--
-- Name: members memberid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.members ALTER COLUMN memberid SET DEFAULT nextval('public.members_memberid_seq'::regclass);


--
-- Name: reports reportid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reports ALTER COLUMN reportid SET DEFAULT nextval('public.reports_reportid_seq'::regclass);


--
-- Name: transactions transactionid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.transactions ALTER COLUMN transactionid SET DEFAULT nextval('public.transactions_transactionid_seq'::regclass);


--
-- Data for Name: admins; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.admins (adminid, name, salt, password, email) FROM stdin;
2003	مهدی عیوضی	cz4Sy+El1F7YsTspZaAP9g==	cz4Sy+El1F7YsTspZaAP9lz7Lmh9pOSLQB09iYCMLljxANCT	mahdiEivazi@gmail.com
\.


--
-- Data for Name: authors; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.authors (authorid, author_name, birth_date) FROM stdin;
1	J.K. Rowling	1965-07-31
2	Stephen King	1947-09-21
3	J.R.R. Tolkien	1892-01-03
4	Dan Brown	1964-06-22
5	Harper Lee	1960-07-11
6	F. Scott Fitzgerald	1925-04-10
7	Peter Linz	1967-06-28
8	Robert C. Martin	1960-07-21
9	Erich Gamma	1970-02-10
10	Dave Thomas and Andy Hunt	1990-12-30
11	MahdiEivazi	-infinity
12	Unknown	-infinity
13	tesw	-infinity
14	Joseph Albahar	\N
15	Mark.j.Price	-infinity
\.


--
-- Data for Name: books; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.books (bookid, title, isbn, genre, published_date, format, file_path, isvalid, authorname) FROM stdin;
2	Harry Potter and the Philosopher's Stone	9780590353427	Fantasy	1997-06-26	PDF	/path/to/harry_potter.pdf	true	J.K. Rowling
8	Harry Potter and the Sorcerer's Stone	9780590353427	Fantasy	1997-06-26	pdf	Harry Potter and the Sorcerers Stone	true	J.K. Rowling
9	The Lord of the Rings: The Fellowship of the Ring	9780618640157	Fantasy	1954-07-29	pdf	The Fellowship Of The Ring	true	J.R.R. Tolkien
10	To Kill a Mockingbird	9780061120084	Fiction	1960-07-11	pdf	To-Kill-A-Mockingbird	true	Harper Lee
12	An Introduction to Formal Languages and Automata	978-1-284-07724-7	Programming	1990-02-23	pdf	An Introduction to Formal Languages and Automata 6th Edition	true	Peter Linz
19	Clean Code	9780132350884	Software Development	2008-08-11	pdf	Clean Code A Handbook of Agile Software Craftsmanship 	true	Robert C. Martin
20	The Pragmatic Programmer	9780201616224	Software Development	1999-10-20	pdf	The Pragmatic Programmer, 2nd Edition	true	Dave Thomas and Andy Hunt
21	Design Patterns	9780201633610	Software Design	1994-10-31	pdf	Addison.Wesley.Design.Patterns.Elements.of.Reusable.Object-Oriented.Software.Oct.1994	true	Erich Gamma
3	The Shining	9780385121675	Horror	1977-01-28	pdf	The-Shining	true	Stephen King
11	The Great Gatsby	9780743273565	Classic	1925-04-10	pdf	The-Great-Gatsby	true	F. Scott Fitzgerald
22	psp	4002116	Methodology	-infinity	pdf	PSP-Methodology	\N	MahdiEivazi
23	tmp	123	test	-infinity	pdf	ch02.pdf	\N	Unknown
24	esdf	321	sf	-infinity	pdf	4-2ConstraintSatisfication_II_2018	\N	tesw
26	C# 11 and .net 7	987-1-80323-780-0	Programming	-infinity	pdf	CSharp.11.and.NET.7.Modern.Cross-Platform.Development.Fundamentals.7th.Edition.Mark.J.Price.Packt.9781803237800.EBooksWorld.ir	true	Mark.j.Price
25	C#10 in a Nutshell	978-1-098-12195-2	Programming	2019-02-20	pdf	CSharp.10.in.a.Nutshell.Joseph.Albahari.OReilly.9781098121952.EBooksWorld.ir	true	Joseph Albahar
\.


--
-- Data for Name: configurations; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.configurations (maxloantime, maxloannumber, finedefault) FROM stdin;
3	3	3
\.


--
-- Data for Name: employee; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.employee (employeeid, name, status, email, phone, password, salt) FROM stdin;
11	Mahdi Eivazi2	True	mahdi@gmail.com	09456374565	N7XiFiFnrsAF3fyf/RzE1lHrwDvFQVUbN5US2r5TAbFIhsMs	N7XiFiFnrsAF3fyf/RzE1g==
\.


--
-- Data for Name: members; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.members (memberid, name, email, phone, fine, password, salt) FROM stdin;
14	مهدی عیوضی	mahdieivazi.40021160028@gmail.com	09396968892	0	RJivRa3l6T+M2ZG9iUwLLyJ52GtVPq+sH6uH9HRRCUcj5CuJ	RJivRa3l6T+M2ZG9iUwLLw==
7	Student	Student@gmail.com	5402	4	eZIpS2lOhbr/rCC26np4nruiN9ybaNzlNtYJllpA4u3/TfXs	eZIpS2lOhbr/rCC26np4ng==
\.


--
-- Data for Name: reports; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.reports (reportid, description, bookid, memberid) FROM stdin;
1	کتاب در صفحه 10 ناخوانا است	10	7
2	صفحات کتاب واضح نیست	10	14
3	صفحات کتاب واضح نیست	3	14
\.


--
-- Data for Name: transactions; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.transactions (transactionid, memberid, bookid, borrow_date, return_date, status, userveiw) FROM stdin;
7	7	2	2024-01-24	2024-02-14	True	
10	7	8	2024-01-24	2024-02-14	True	
11	7	12	2024-01-24	2024-02-14	True	
13	7	12	2024-01-25	2024-02-15	True	
9	7	9	2024-01-24	2024-02-14	True	
14	7	9	2024-01-25	2024-02-15	True	
18	7	22	2024-01-28	2024-02-18	False	
19	7	24	2024-01-28	2024-02-18	False	
8	7	3	2024-01-24	2024-02-14	True	good
21	14	19	2024-01-29	2024-02-19	True	
12	7	21	2024-01-24	2024-02-14	True	
25	14	3	2024-01-29	2024-02-19	False	
23	14	20	2024-01-29	2024-02-19	True	
20	14	19	2024-01-29	2024-02-19	True	کتاب مفیدی است
22	14	21	2024-01-29	2024-02-19	True	کتاب کاربردی  است
24	14	10	2024-01-29	2024-02-19	False	کتاب کاربردی و مفید است
\.


--
-- Name: authors_authorid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.authors_authorid_seq', 15, true);


--
-- Name: books_bookid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.books_bookid_seq', 26, true);


--
-- Name: employee_employeeid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.employee_employeeid_seq', 11, true);


--
-- Name: members_memberid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.members_memberid_seq', 19, true);


--
-- Name: reports_reportid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.reports_reportid_seq', 3, true);


--
-- Name: transactions_transactionid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.transactions_transactionid_seq', 25, true);


--
-- Name: admins admins_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.admins
    ADD CONSTRAINT admins_pkey PRIMARY KEY (adminid);


--
-- Name: authors authors_author_name_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.authors
    ADD CONSTRAINT authors_author_name_key UNIQUE (author_name);


--
-- Name: authors authors_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.authors
    ADD CONSTRAINT authors_pkey PRIMARY KEY (authorid);


--
-- Name: books books_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.books
    ADD CONSTRAINT books_pkey PRIMARY KEY (bookid);


--
-- Name: configurations configurations_maxloannumber_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.configurations
    ADD CONSTRAINT configurations_maxloannumber_key UNIQUE (maxloannumber);


--
-- Name: configurations configurations_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.configurations
    ADD CONSTRAINT configurations_pkey PRIMARY KEY (maxloantime);


--
-- Name: employee employee_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.employee
    ADD CONSTRAINT employee_pkey PRIMARY KEY (employeeid);


--
-- Name: members members_password_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.members
    ADD CONSTRAINT members_password_key UNIQUE (password);


--
-- Name: members members_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.members
    ADD CONSTRAINT members_pkey PRIMARY KEY (memberid);


--
-- Name: reports reports_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reports
    ADD CONSTRAINT reports_pkey PRIMARY KEY (reportid);


--
-- Name: transactions transactions_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.transactions
    ADD CONSTRAINT transactions_pkey PRIMARY KEY (transactionid);


--
-- Name: books books_authorname_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.books
    ADD CONSTRAINT books_authorname_fkey FOREIGN KEY (authorname) REFERENCES public.authors(author_name);


--
-- Name: reports reports_bookid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reports
    ADD CONSTRAINT reports_bookid_fkey FOREIGN KEY (bookid) REFERENCES public.books(bookid);


--
-- Name: reports reports_memberid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reports
    ADD CONSTRAINT reports_memberid_fkey FOREIGN KEY (memberid) REFERENCES public.members(memberid);


--
-- Name: transactions transaction_bookid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.transactions
    ADD CONSTRAINT transaction_bookid_fkey FOREIGN KEY (bookid) REFERENCES public.books(bookid) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: transactions transactions_memberid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.transactions
    ADD CONSTRAINT transactions_memberid_fkey FOREIGN KEY (memberid) REFERENCES public.members(memberid) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--

