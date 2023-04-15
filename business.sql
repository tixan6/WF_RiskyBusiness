PGDMP     (                    {            business    10.23    10.23 1               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false                        0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false            !           1262    65536    business    DATABASE     �   CREATE DATABASE business WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Russian_Belarus.1251' LC_CTYPE = 'Russian_Belarus.1251';
    DROP DATABASE business;
             postgres    false                        2615    2200    publics    SCHEMA        CREATE SCHEMA publics;
    DROP SCHEMA publics;
             postgres    false            "           0    0    SCHEMA publics    COMMENT     7   COMMENT ON SCHEMA publics IS 'standard public schema';
                  postgres    false    3                        3079    12924    plpgsql 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
    DROP EXTENSION plpgsql;
                  false            #           0    0    EXTENSION plpgsql    COMMENT     @   COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';
                       false    1            �            1259    65567    NameOfCompany    TABLE       CREATE TABLE publics."NameOfCompany" (
    "NameCompany" text NOT NULL,
    "id_Cur" integer NOT NULL,
    "id_Non" integer NOT NULL,
    id_obl integer NOT NULL,
    id integer NOT NULL,
    "KTL" money NOT NULL,
    "KBL" money NOT NULL,
    "KAL" money NOT NULL
);
 $   DROP TABLE publics."NameOfCompany";
       publics         postgres    false    3            $           0    0    TABLE "NameOfCompany"    COMMENT     M   COMMENT ON TABLE publics."NameOfCompany" IS 'Имя предприятия';
            publics       postgres    false    198            �            1259    65600    NameOfCompany_id_seq    SEQUENCE     �   CREATE SEQUENCE publics."NameOfCompany_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE publics."NameOfCompany_id_seq";
       publics       postgres    false    198    3            %           0    0    NameOfCompany_id_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE publics."NameOfCompany_id_seq" OWNED BY publics."NameOfCompany".id;
            publics       postgres    false    202            �            1259    73728    CurrentAssets    TABLE     i  CREATE TABLE publics."CurrentAssets" (
    id integer DEFAULT nextval('publics."NameOfCompany_id_seq"'::regclass) NOT NULL,
    "Stocks" money NOT NULL,
    "NDS" money NOT NULL,
    "Debet" money NOT NULL,
    "Financial" money NOT NULL,
    "Other" money NOT NULL,
    "Obligations" money NOT NULL,
    "SumTwo" money NOT NULL,
    id_obl integer NOT NULL
);
 $   DROP TABLE publics."CurrentAssets";
       publics         postgres    false    202    3            &           0    0    TABLE "CurrentAssets"    COMMENT     O   COMMENT ON TABLE publics."CurrentAssets" IS 'Оборотные активы';
            publics       postgres    false    203            �            1259    65573    NameOfCompany_id_Cur_seq    SEQUENCE     �   CREATE SEQUENCE publics."NameOfCompany_id_Cur_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE publics."NameOfCompany_id_Cur_seq";
       publics       postgres    false    3    198            '           0    0    NameOfCompany_id_Cur_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE publics."NameOfCompany_id_Cur_seq" OWNED BY publics."NameOfCompany"."id_Cur";
            publics       postgres    false    199            �            1259    65582    NameOfCompany_id_Non_seq    SEQUENCE     �   CREATE SEQUENCE publics."NameOfCompany_id_Non_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE publics."NameOfCompany_id_Non_seq";
       publics       postgres    false    198    3            (           0    0    NameOfCompany_id_Non_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE publics."NameOfCompany_id_Non_seq" OWNED BY publics."NameOfCompany"."id_Non";
            publics       postgres    false    200            �            1259    65591    NameOfCompany_id_obl_seq    SEQUENCE     �   CREATE SEQUENCE publics."NameOfCompany_id_obl_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE publics."NameOfCompany_id_obl_seq";
       publics       postgres    false    3    198            )           0    0    NameOfCompany_id_obl_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE publics."NameOfCompany_id_obl_seq" OWNED BY publics."NameOfCompany".id_obl;
            publics       postgres    false    201            �            1259    73735    Non-currentAssets    TABLE     2  CREATE TABLE publics."Non-currentAssets" (
    id integer DEFAULT nextval('publics."NameOfCompany_id_seq"'::regclass) NOT NULL,
    "IntangibleAssets" money NOT NULL,
    "FixedAssets" money NOT NULL,
    "FinancialInvestments" money NOT NULL,
    "SumOne" money NOT NULL,
    "id_Cur" integer NOT NULL
);
 (   DROP TABLE publics."Non-currentAssets";
       publics         postgres    false    202    3            *           0    0    TABLE "Non-currentAssets"    COMMENT     Y   COMMENT ON TABLE publics."Non-currentAssets" IS 'Внеоборотные активы';
            publics       postgres    false    204            �            1259    65561    Obligations    TABLE     �   CREATE TABLE publics."Obligations" (
    id integer NOT NULL,
    "Loan" money NOT NULL,
    "Credit" money NOT NULL,
    "Income" money NOT NULL,
    "MarksCommitment" money NOT NULL,
    "SumThree" money NOT NULL
);
 "   DROP TABLE publics."Obligations";
       publics         postgres    false    3            +           0    0    TABLE "Obligations"    COMMENT     H   COMMENT ON TABLE publics."Obligations" IS 'Обязательства';
            publics       postgres    false    197            �            1259    65559    Obligations_id_seq    SEQUENCE     �   CREATE SEQUENCE publics."Obligations_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE publics."Obligations_id_seq";
       publics       postgres    false    3    197            ,           0    0    Obligations_id_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE publics."Obligations_id_seq" OWNED BY publics."Obligations".id;
            publics       postgres    false    196            �
           2604    65575    NameOfCompany id_Cur    DEFAULT     �   ALTER TABLE ONLY publics."NameOfCompany" ALTER COLUMN "id_Cur" SET DEFAULT nextval('publics."NameOfCompany_id_Cur_seq"'::regclass);
 H   ALTER TABLE publics."NameOfCompany" ALTER COLUMN "id_Cur" DROP DEFAULT;
       publics       postgres    false    199    198            �
           2604    65584    NameOfCompany id_Non    DEFAULT     �   ALTER TABLE ONLY publics."NameOfCompany" ALTER COLUMN "id_Non" SET DEFAULT nextval('publics."NameOfCompany_id_Non_seq"'::regclass);
 H   ALTER TABLE publics."NameOfCompany" ALTER COLUMN "id_Non" DROP DEFAULT;
       publics       postgres    false    200    198            �
           2604    65593    NameOfCompany id_obl    DEFAULT     �   ALTER TABLE ONLY publics."NameOfCompany" ALTER COLUMN id_obl SET DEFAULT nextval('publics."NameOfCompany_id_obl_seq"'::regclass);
 F   ALTER TABLE publics."NameOfCompany" ALTER COLUMN id_obl DROP DEFAULT;
       publics       postgres    false    201    198            �
           2604    65602    NameOfCompany id    DEFAULT     z   ALTER TABLE ONLY publics."NameOfCompany" ALTER COLUMN id SET DEFAULT nextval('publics."NameOfCompany_id_seq"'::regclass);
 B   ALTER TABLE publics."NameOfCompany" ALTER COLUMN id DROP DEFAULT;
       publics       postgres    false    202    198            �
           2604    65564    Obligations id    DEFAULT     v   ALTER TABLE ONLY publics."Obligations" ALTER COLUMN id SET DEFAULT nextval('publics."Obligations_id_seq"'::regclass);
 @   ALTER TABLE publics."Obligations" ALTER COLUMN id DROP DEFAULT;
       publics       postgres    false    196    197    197                      0    73728    CurrentAssets 
   TABLE DATA                  COPY publics."CurrentAssets" (id, "Stocks", "NDS", "Debet", "Financial", "Other", "Obligations", "SumTwo", id_obl) FROM stdin;
    publics       postgres    false    203   �8                 0    65567    NameOfCompany 
   TABLE DATA               n   COPY publics."NameOfCompany" ("NameCompany", "id_Cur", "id_Non", id_obl, id, "KTL", "KBL", "KAL") FROM stdin;
    publics       postgres    false    198   �8                 0    73735    Non-currentAssets 
   TABLE DATA               �   COPY publics."Non-currentAssets" (id, "IntangibleAssets", "FixedAssets", "FinancialInvestments", "SumOne", "id_Cur") FROM stdin;
    publics       postgres    false    204   �8                 0    65561    Obligations 
   TABLE DATA               g   COPY publics."Obligations" (id, "Loan", "Credit", "Income", "MarksCommitment", "SumThree") FROM stdin;
    publics       postgres    false    197   9       -           0    0    NameOfCompany_id_Cur_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('publics."NameOfCompany_id_Cur_seq"', 1, false);
            publics       postgres    false    199            .           0    0    NameOfCompany_id_Non_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('publics."NameOfCompany_id_Non_seq"', 1, false);
            publics       postgres    false    200            /           0    0    NameOfCompany_id_obl_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('publics."NameOfCompany_id_obl_seq"', 1, false);
            publics       postgres    false    201            0           0    0    NameOfCompany_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('publics."NameOfCompany_id_seq"', 28, true);
            publics       postgres    false    202            1           0    0    Obligations_id_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('publics."Obligations_id_seq"', 29, true);
            publics       postgres    false    196            �
           2606    73734     CurrentAssets CurrentAssets_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY publics."CurrentAssets"
    ADD CONSTRAINT "CurrentAssets_pkey" PRIMARY KEY (id);
 O   ALTER TABLE ONLY publics."CurrentAssets" DROP CONSTRAINT "CurrentAssets_pkey";
       publics         postgres    false    203            �
           2606    65610     NameOfCompany NameOfCompany_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY publics."NameOfCompany"
    ADD CONSTRAINT "NameOfCompany_pkey" PRIMARY KEY (id);
 O   ALTER TABLE ONLY publics."NameOfCompany" DROP CONSTRAINT "NameOfCompany_pkey";
       publics         postgres    false    198            �
           2606    73741 (   Non-currentAssets Non-currentAssets_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY publics."Non-currentAssets"
    ADD CONSTRAINT "Non-currentAssets_pkey" PRIMARY KEY (id);
 W   ALTER TABLE ONLY publics."Non-currentAssets" DROP CONSTRAINT "Non-currentAssets_pkey";
       publics         postgres    false    204            �
           2606    65566    Obligations Obligations_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY publics."Obligations"
    ADD CONSTRAINT "Obligations_pkey" PRIMARY KEY (id);
 K   ALTER TABLE ONLY publics."Obligations" DROP CONSTRAINT "Obligations_pkey";
       publics         postgres    false    197            �
           2606    73762    CurrentAssets Fk_CurToObl    FK CONSTRAINT     �   ALTER TABLE ONLY publics."CurrentAssets"
    ADD CONSTRAINT "Fk_CurToObl" FOREIGN KEY (id_obl) REFERENCES publics."Obligations"(id) NOT VALID;
 H   ALTER TABLE ONLY publics."CurrentAssets" DROP CONSTRAINT "Fk_CurToObl";
       publics       postgres    false    203    2702    197            �
           2606    73747    NameOfCompany Fk_NameToCur    FK CONSTRAINT     �   ALTER TABLE ONLY publics."NameOfCompany"
    ADD CONSTRAINT "Fk_NameToCur" FOREIGN KEY ("id_Cur") REFERENCES publics."CurrentAssets"(id) NOT VALID;
 I   ALTER TABLE ONLY publics."NameOfCompany" DROP CONSTRAINT "Fk_NameToCur";
       publics       postgres    false    203    2706    198            �
           2606    73742    NameOfCompany Fk_NameToNon    FK CONSTRAINT     �   ALTER TABLE ONLY publics."NameOfCompany"
    ADD CONSTRAINT "Fk_NameToNon" FOREIGN KEY ("id_Non") REFERENCES publics."Non-currentAssets"(id) NOT VALID;
 I   ALTER TABLE ONLY publics."NameOfCompany" DROP CONSTRAINT "Fk_NameToNon";
       publics       postgres    false    204    2708    198            �
           2606    73752    NameOfCompany Fk_NameToObl    FK CONSTRAINT     �   ALTER TABLE ONLY publics."NameOfCompany"
    ADD CONSTRAINT "Fk_NameToObl" FOREIGN KEY (id_obl) REFERENCES publics."Obligations"(id) NOT VALID;
 I   ALTER TABLE ONLY publics."NameOfCompany" DROP CONSTRAINT "Fk_NameToObl";
       publics       postgres    false    197    2702    198            �
           2606    73757    Non-currentAssets Fk_NonToCur    FK CONSTRAINT     �   ALTER TABLE ONLY publics."Non-currentAssets"
    ADD CONSTRAINT "Fk_NonToCur" FOREIGN KEY ("id_Cur") REFERENCES publics."CurrentAssets"(id) NOT VALID;
 L   ALTER TABLE ONLY publics."Non-currentAssets" DROP CONSTRAINT "Fk_NonToCur";
       publics       postgres    false    2706    203    204                  x������ � �            x������ � �            x������ � �            x������ � �     