﻿/*
This file is part of PacketDotNet

PacketDotNet is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

PacketDotNet is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with PacketDotNet.  If not, see <http://www.gnu.org/licenses/>.
*/
/*
 *  Copyright 2017 Andrew <pandipd@outlook.com>
 */

using System;

namespace PacketDotNet
{
    /// <summary>
    /// Drda Code Point Type
    /// </summary>
    public enum DrdaCodepointType:ushort
    {
#pragma warning disable 1591
        DATA = 0x0000,
        CODPNT = 0x000C,
        FDODSC = 0x0010,
        TYPDEFNAM = 0x002F,
        TYPDEFOVR = 0x0035,
        CODPNTDR = 0x0064,
        EXCSAT = 0x1041,
        SYNCCTL = 0x1055,
        SYNCRSY = 0x1069,
        ACCSEC = 0x106D,
        SECCHK = 0x106E,
        SYNCLOG = 0x106F,
        RSCTYP = 0x111F,
        RSNCOD = 0x1127,
        RSCNAM = 0x112D,
        PRDID = 0x112E,
        PRCCNVCD = 0x113F,
        VRSNAM = 0x1144,
        SRVCLSNM = 0x1147,
        SVRCOD = 0x1149,
        SYNERRCD = 0x114A,
        SRVDGN = 0x1153,
        SRVRLSLV = 0x115A,
        SPVNAM = 0x115D,
        EXTNAM = 0x115E,
        SRVNAM = 0x116D,
        SECMGRNM = 0x1196,
        DEPERRCD = 0x119B,
        CCSIDSBC = 0x119C,
        CCSIDDBC = 0x119D,
        CCSIDMBC = 0x119E,
        USRID = 0x11A0,
        PASSWORD = 0x11A1,
        SECMEC = 0x11A2,
        SECCHKCD = 0x11A4,
        SVCERRNO = 0x11B4,
        SECTKN = 0x11DC,
        NEWPASSWORD = 0x11DE,
        MGRLVLRM = 0x1210,
        MGRDEPRM = 0x1218,
        SECCHKRM = 0x1219,
        CMDATHRM = 0x121C,
        AGNPRMRM = 0x1232,
        RSCLMTRM = 0x1233,
        PRCCNVRM = 0x1245,
        CMDCMPRM = 0x124B,
        SYNTAXRM = 0x124C,
        CMDNSPRM = 0x1250,
        PRMNSPRM = 0x1251,
        VALNSPRM = 0x1252,
        OBJNSPRM = 0x1253,
        CMDCHKRM = 0x1254,
        TRGNSPRM = 0x125F,
        AGENT = 0x1403,
        MGRLVLLS = 0x1404,
        SUPERVISOR = 0x143C,
        SECMGR = 0x1440,
        EXCSATRD = 0x1443,
        CMNAPPC = 0x1444,
        DICTIONARY = 0x1458,
        MGRLVLN = 0x1473,
        CMNTCPIP = 0x1474,
        FDODTA = 0x147A,
        CMNSYNCPT = 0x147C,
        ACCSECRD = 0x14AC,
        SYNCPTMGR = 0x14C0,
        RSYNCMGR = 0x14C1,
        CCSIDMGR = 0x14CC,
        MONITOR = 0x1900,
        MONITORRD = 0x1C00,
        XAMGR = 0x1C01,
        ACCRDB = 0x2001,
        BGNBND = 0x2002,
        BNDSQLSTT = 0x2004,
        CLSQRY = 0x2005,
        CNTQRY = 0x2006,
        DRPPKG = 0x2007,
        DSCSQLSTT = 0x2008,
        ENDBND = 0x2009,
        EXCSQLIMM = 0x200A,
        EXCSQLSTT = 0x200B,
        OPNQRY = 0x200C,
        PRPSQLSTT = 0x200D,
        RDBCMM = 0x200E,
        RDBRLLBCK = 0x200F,
        REBIND = 0x2010,
        DSCRDBTBL = 0x2012,
        EXCSQLSET = 0x2014,
        DSCERRCD = 0x2101,
        QRYPRCTYP = 0x2102,
        RDBINTTKN = 0x2103,
        PRDDTA = 0x2104,
        RDBCMTOK = 0x2105,
        RDBCOLID = 0x2108,
        PKGID = 0x2109,
        PKGCNSTKN = 0x210D,
        RTNSETSTT = 0x210E,
        RDBACCCL = 0x210F,
        RDBNAM = 0x2110,
        OUTEXP = 0x2111,
        PKGNAMCT = 0x2112,
        PKGNAMCSN = 0x2113,
        QRYBLKSZ = 0x2114,
        UOWDSP = 0x2115,
        RTNSQLDA = 0x2116,
        RDBALWUPD = 0x211A,
        SQLCSRHLD = 0x211F,
        STTSTRDEL = 0x2120,
        STTDECDEL = 0x2121,
        PKGDFTCST = 0x2125,
        QRYBLKCTL = 0x2132,
        CRRTKN = 0x2135,
        PRCNAM = 0x2138,
        PKGSNLST = 0x2139,
        NBRROW = 0x213A,
        TRGDFTRT = 0x213B,
        QRYRELSCR = 0x213C,
        QRYROWNBR = 0x213D,
        QRYRFRTBL = 0x213E,
        MAXRSLCNT = 0x2140,
        MAXBLKEXT = 0x2141,
        RSLSETFLG = 0x2142,
        TYPSQLDA = 0x2146,
        OUTOVROPT = 0x2147,
        RTNEXTDTA = 0x2148,
        QRYATTSCR = 0x2149,
        QRYATTUPD = 0x2150,
        QRYSCRORN = 0x2152,
        QRYROWSNS = 0x2153,
        QRYBLKRST = 0x2154,
        QRYRTNDTA = 0x2155,
        QRYROWSET = 0x2156,
        QRYATTSNS = 0x2157,
        QRYINSID = 0x215B,
        QRYCLSIMP = 0x215D,
        QRYCLSRLS = 0x215E,
        QRYOPTVAL = 0x215F,
        DIAGLVL = 0x2160,
        ACCRDBRM = 0x2201,
        QRYNOPRM = 0x2202,
        RDBNACRM = 0x2204,
        OPNQRYRM = 0x2205,
        PKGBNARM = 0x2206,
        RDBACCRM = 0x2207,
        BGNBNDRM = 0x2208,
        PKGBPARM = 0x2209,
        DSCINVRM = 0x220A,
        ENDQRYRM = 0x220B,
        ENDUOWRM = 0x220C,
        ABNUOWRM = 0x220D,
        DTAMCHRM = 0x220E,
        QRYPOPRM = 0x220F,
        RDBNFNRM = 0x2211,
        OPNQFLRM = 0x2212,
        SQLERRRM = 0x2213,
        RDBUPDRM = 0x2218,
        RSLSETRM = 0x2219,
        RDBAFLRM = 0x221A,
        CMDVLTRM = 0x221D,
        CMMRQSRM = 0x2225,
        RDBATHRM = 0x22CB,
        SQLAM = 0x2407,
        SQLCARD = 0x2408,
        SQLCINRD = 0x240B,
        SQLRSLRD = 0x240E,
        RDB = 0x240F,
        FRCFIXROW = 0x2410,
        SQLDARD = 0x2411,
        SQLDTA = 0x2412,
        SQLDTARD = 0x2413,
        SQLSTT = 0x2414,
        OUTOVR = 0x2415,
        LMTBLKPRC = 0x2417,
        FIXROWPRC = 0x2418,
        SQLSTTVRB = 0x2419,
        QRYDSC = 0x241A,
        QRYDTA = 0x241B,
        CSTMBCS = 0x2435,
        SRVLST = 0x244E,
        SQLATTR = 0x2450,
        DYNDTAFMT = 0x214B
#pragma warning restore 1591
    }
}
