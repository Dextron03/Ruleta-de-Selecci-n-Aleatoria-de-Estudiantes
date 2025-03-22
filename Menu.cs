using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ruleta;

public class Menu{

    public string ruleta4 = @"
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNXKOkdol:;,'...                    ...',;:codkOKXNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNK0xoc;,..            ....................            ..,;cox0XNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWX0xl:,.        ..';:cldxkkO0KKXXXXNNNNNNXXXXKK0Okkxdlc:;'..        .,:lx0XWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWN0xl;..      .':loxOKXNWWMMWWWNXXKK00OOOOOOOOOO00KKXXNWWMMMWWNXKOxol:'.      ..;lx0NWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOo:'.     .,:ox0XNWMMWNX0Oxolc:;,'.....            .....',;:cloxk0XNWMMWNX0xo:,.     .':oOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNOo:.     .,cdOKNWMWNKOxoc;'..                                        ..';coxOKNWMMNKOdc,.     .:oONWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKxc'     .;lkKNWMWXOxl;'.                                                        .':lx0XWMWNKkl;.     'cxKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd:.    .,lkKWMWN0xl;.                                                                    .;lx0NWMWKkl,.    .;dKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd;.    .:x0NMWN0d:'.                                                                            .'cd0NWMN0x:.    .;dKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXx:.    'ckXWMWKxc'.                                                                                    .'cxKWMWXkc.    .:xXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMW0l'    .ckXWMN0o;.                                                                                            .;o0NMWXkc.    'l0WMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXx;.   .:xXWMNOo,.                                 ..',;:clooddxxxxxxxxddoolc:;,'..                                 .,oONMWXx;.   .;xXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd,    'o0WMW0o,.                            ..;cldk0KXNWWMMMMMMMMMMMMMMMMMMMMMMWWNXK0kdlc,..                            .,o0WMW0o'    'dKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMWKo.   .;xXWMXx:.                         ..;cdkKXWMMMMMMMMMMMMWWWNNNNXXXXNNNNWWWMMMMMMMMMMMMWNKkdc;..                         .:xXWWXx;.   .oKWMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMWKo.   .:ONMW0o'                        .,cx0XWMMMMMMMWWXXNWKdlc:;,,''........'',,;:clxXWKKXWWMMMMMMMWX0xc,.                        'o0WMNOc.   .oKWMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMWKo.   .c0WMNOc.                      .,lkKWMMMMMMWNKOdl:,..oNx.                        ,KO,..,:ldOKNWMMMMMMNKkl,.                      .cONMW0c.   .oKWMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMXd'   .c0WMNk:.                     .cxKWMMMMMWN0xl:'.       ,0K,       .,cl:;.          lXl        .':lx0NWMMMMMNKxc.                     .:kNMW0c.   'dXMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMWk;   .:OWMNk;.                    'lkXWMMMMWNOd:'.            .dNl      .xNMMWWK:        .k0'             .':dOXWMMMMWXkl'                    .;kNMWO:.   ;kWMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMWKc.   ,kNMWO:.                   .ckXWMMMMW0d:'       .          ;Kk.     '0MMMMMNl        ;Kd.      '::;.       ':dKWMMMMWXkc.                   .:OWMNk,   .cKWMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMNx'   .oXMW0c.                  .;xXWMMMMMXd;.       'oO0Oo.       .xK;      ,dO0kxc.        o0;     .dXWMW0;         .;kWMMMMMWXx;.                  .c0WMXo.   'xNMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWKc.   :0WMXo.                  .lONMMMMW0x0Kc        .kWMMMWx.       :Kd.                    .Ox.     '0MMMMWo          ,OXxd0WMMMMN0l.                  .oXMW0:   .cKMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMWk'   .dNMWO,                  'oKWMMMWXx;. .dKo.      .oXMMMXl        .kO'                    :0c       ;kKK0o.         cK0:  .;xXWMMMWKo'                  ,OWMNd.   'kWMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMXo.   ;0WMXl.                 'dXMMMMW0l.     .c0k'       'clc'          lKc                   .dk.         ...         .oKk'      .l0WMMMMXd'                 .lXMW0;   .oXMMMMMMMMMMMMMM
MMMMMMMMMMMMMKc   .oXMWO;                 .dXMMMMNO:.         'kO:           ...       'Ox.                  'kl                     'kKo.         .:ONMMMMXd.                 ;OWMXo.   cKMMMMMMMMMMMMM
MMMMMMMMMMMM0;   .xNMNd.                .lKWMMMNk;.            .oOl.         'OO:.      oO,                  ck,                    ;OO;             .;kNMMMWKl.                .dNMWx.   ;0MMMMMMMMMMMM
MMMMMMMMMMWO'   ,OWMXl.                ;OWMMMWO:.    ...         ;kx.        ,KXOx:.    ,Ol                 .dd.                  .l0x.     .ck0Od,    .:OWMMMW0:                .lXMWO,   'OWMMMMMMMMMM
MMMMMMMMMWk'   ;0MMK:                .dNMMMWKc.    ,xKX0o.        .dk;       ;Kd'ckk:.  .dx.                ,x:                  .d0c.      cNMMMM0,     .cKWMMMNd.                :KMM0;   'kWMMMMMMMMM
MMMMMMMMWk.   :KMW0,                :0WMMMNd.     .OMMMMWd.        .ckc.     :Kl  .ckk:. ;k;                cd.                 ,kk,        ;0WMMWk.       .dXMMMW0:                ,0WMK:   .kWMMMMMMMM
MMMMMMMWk'   :KMWO,               .oXMMMW0:       .lXWMWK:           ,xo.    cKc    .ckk:,xo               .dc                 :Oo.          .:ll;.          :0WMMMXo.               ,OWMK:   'OWMMMMMMM
MMMMMMMO'   ;KMWO'               'kWMMMMXl.         .;:;.             .lx,   lK:      .ckO0k.              ;d'               .lk:                            .dNMMMMWk'               'OWMK:   'OWMMMMMM
MMMMMM0;   ;0MW0,               ,0WMMMXkOKkl'                           ;d:. oK;        .c0Xo.             cl.              .dx'                          .:xOkodXMMMW0,               ,0MM0;   ;0MMMMMM
MMMMMXc   'OWMK;               ;KMMMM0; .,lk0kc'                         'ol'd0,       .,;:xKk:.          .o,              ;xl.                        .;dkkl'   ;0WMMM0;               ;KMWO'   cXMMMMM
MMMMNo.  .xWMX:               :KMMMWO,      'lkOxc.                       .cxK0, ..    .kNNXNNXk;.        ;l.            .cd;                       .;okxc'       ,OWMMMK:               :XMWx.  .oNMMMM
MMMWk.   oNMNo               ;KMMMWO'          .cxOx:.                      ;K0::0O,    ,0MMWx,,,.       .c;            .lo.                     .,oxxc'           'OWMMMK;               oNMNo.  .kWMMM
MMMK;   ;KMWk.              ,0MMMWO'              .:dkd:.                   .kXKNMWk.    :XMMk.          .c.           'oc.                    'lddc.        ..     'OWMMM0,              .xWMK;   ;KMMM
MMWo.  .kWMK,              'OWMMM0,                  .:dxo;.                .ONOKWMWd.   .oNMK;          ;;           ;l,                   'coo:.        .ckKKkc.   ,0MMMWO'              ,KMMk.  .oWMM
MM0'   lNMNl              .dWMMMK;    ,dkOd;            .;odo;.             .l;.'xNMNl    .xWWo         .:'         .:c.                 .:oo:.           :XMMMMX:    ;KMMMWd.              lNMNl   '0MM
MNl   '0MMO.              cNMMMNl    ;KMMMMX;              .;lol,.               .lXMK;    'OWO.        .;.        .c;                .:ll;.              'kNMMNk'     lNMMMNc              .OMM0'   lNM
M0'   oWMNc              ,0MMMWx.    ,OWMMW0,                 .,clc,.              ;OW0'    ;KX:        ,'        ':'              .;cc;.                  .,cc,.      .xWMMM0,              cNMWo   '0M
Wo   '0MMO.             .dWMMMK,      .:oo:.                     .':c:'.            .dXx.    cXd.      .,.       ,;.            .,::,.                                  ,KMMMWd.             .OMM0'   oW
K;   cNMNl              ;KMMMWo.                                     ':::'            cKo.   .o0:      .'      .,'           .';;,.                                     .oWMMMK;              lNMNc   ;K
k.  .xMM0,             .dWMMM0,                                         .;;;.          o0c    .x0occcccl:.    .,.         .',;'.                                         ;KMMMWd.             ,KMWx.  .k
l   ,KMWx.             '0MMMMKdc;,..                                       .,;,.       .x0;    '0WMMMMMWNXOdc:,.        .','.                                    ..';:ldxONMMMM0'             .xWMK,   l
;   cNMNl              cNMMMNxoodxxxxddoc:,'..                                .','.    .oNO'    ;OKKKKNWMMMMWNk;.    ..'..                              ..';cloxxkkkkxdlc:oXMMMNc              lNMNc   ;
.  .dWMX;             .dWMMMO.     ..',:clooooollc:;,..                          .....;kNMWd.    .;:::::lxKWMMMNk;....                         ..';:lloddddool:;'...      .OMMMWd.             ;XMWd.  .
.  .kMM0'             .OMMMWd.                ..',;:ccccc::;;,...                   .dNMMXx;.    .oXNXKko;,l0WMMMNd.                  ..';::ccllllc:;,...                 .dWMMMO.             '0MMk.  .
   '0MMk.             ,KMMMNc                            ..',,;;;;,,,,'...          lNMW0:'ok:    .,:coONNk;'dNMMMNl        ...',,;;;;:;;;,'..                             lNMMMK,             .kMM0'   
   ,KMMx.             :XMMMX:                                       ....'''........:KMM0,,kWK:         .;OWXc.dWMMMKc.....''''''...                               ...      :XMMMX:             .xMMK,   
   ,KMWd.             cNMMMK;    'ok0kl.                                       ...'kWMNl.dWX:            .kWK,'0MMMWk'..                                        'd0XKx,    ;KMMMNc             .dWMK,   
   ;XMWd              cNMMMK,   .kWMMMWd.                                         .kMMX;'0MO.             lNNl.xMMMMk.                                         .dWMMMMO.   ,KMMMNc              dWMX;   
   ;KMWd.             cNMMMK,   .dNMMMXc                                          .kMMX:.kM0,            .oWX:.kMMMMk.                                          :0WMWXl.   ,KMMMNc             .dWMX;   
   ,KMWd.             :NMMMX;    .,llc'                                   ........'dNMWx.:XWk'          .lXWx.cXMMMNo..........                                  .;:;.     ;XMMMX:             .dWMK,   
   '0MMk.             ;XMMMNc                                  ...',,,,,,,''....   .kWMNd':0WKo;..  ..'cONXd':KMMMWk.    ....''''',,,''...                                 cNMMMX;             .kMM0'   
.  .OMMO.             '0MMMWo                        ..',;:ccc:::;;,'..             ,OWMWk:,lOXNX0O00KNNKd;,oXMMMMO,              ...',;;;;::::;;,...                      oWMMM0'             .OMMO.  .
.  .xWMK,             .kMMMMx.            ..',:clooooolcc:,'..                     ..;kNMMNkl;;:loooooc:;:dKWMMMNk:'.                       ..',::cclllllc:;,...          .xMMMMk.             ,KMMx.  .
,   oWMX:              oWMMM0, ...,;clodxxxxddoc:,'..                           ..... .;kNMMWN0kdoloooxOXWMMMMNk;. ..''.                             ...,;cloodddddolc;,..:KMMMWo              :XMWo   ,
c   :XMWd.             ;KMMMWKOOOOkkdoc:,...                                 .''..      .ck0NWMMMMMMMMMMMMWN0xc.      .',,'.                                   ..';:lodxkkKWMMMK;             .dWMX:   c
d.  .OMMO.             .kMMMMXl,..                                        .,,'.         .'..':ok0000K000ko:'....         .';;'.                                         .;0MMMMk.             .OMMO.  .d
0'  .oWMX:              cNMMMX:                                        .,;,.          .,'      .'......,'      .'.          .,::,.                                       :XMMMNc              :XMWo.  '0
Nc   ;KMWx.             .OMMMWk.                                    ';:;.            .;.       '.      .,.      .,.            .;cc;.                        ....       .kWMMMO.             .dWMK;   cN
Wx.  .xWMK;              cXMMMNl         ..                      ':c:'              ,:.       .,        ;'       .,,.             .;ll;.                   .l0XX0l.     lNMMMXc              ;KMWx.  .xW
MX;   :XMWd.             .xWMMM0,     .:k00k:.               .':lc'.              .:;.        ,'        ':.        ':.               .:oo:.                cXMMMMX:    ,0MMMWx.             .dWMX:   ;XM
MWx.  .xWMK;              ,0MMMWk.    :XMMMMX:            .,clc,.                'c,         .;.        .:'         .:,                 .cooc'             .xNWWNx.   .kWMMM0,              ;KMWx.  .xWM
MMX:   ;KMWk.              :XMMMWd.   'OWMMWO'         .,lol;.                 .:l.          ,;          ;:          .::.                  'cddc'           .';;'    .dWMMMX:              .kWMK;   :XMM
MMMk.  .oNMNl              .oNMMMNl.   .;cc;.       .,ldo;.                   .lc.          .:,          'l.           ;l'                    'lxxl,.               .lNMMMNo.              lNMNo.  .kMMM
MMMNo   .kMMK;              .dWMMMNl             .;oxd:.                     ,o:            'c.          .l:            'l:.                    .,okko,.           .lXMMMWd.              ;KMMk.   oNMMM
MMMMK;   ;KMMO.              .xWMMMNl.        .;okdc.                      .cd,             c:            ;o.            .cl.                      .,okOd;.       .lXMMMWx.              .OMMK;   ;KMMMM
MMMMMO'   cXMWx.              .xWMMMNo.    .;dkxc'                        'do.             .o'            .d:              :d;                        .;oOOd:.   .oNMMMWd.              .xWMXc   'OMMMMM
MMMMMWx.  .oNMNo.              .dNMMMNx'.:dOkl'                          :xc.              :l.             lo.              ,dl.                         .;d00x:;xNMMMNd.              .oNMNo.  .xWMMMMM
MMMMMMNo.  .dWMNo.              .lXMMMWX0Oo,.                          .ok;               .o:              ,x,               .od'                           .:xXWWMMMXl.              .lNMWd.  .oNMMMMMM
MMMMMMMNl   .xWMNl.               :KWMMMNd.            ..             ,xx'                ;d'              .do                .cx:            .lk0Oo'        .oXMMMW0:               .lNMWx.   lNMMMMMMM
MMMMMMMMXc   .xWMNo.               'kWMMMWk,         :kKKOl.        .cOo.                .oo.               ck'                 ,xo.         .dWMMMMk.      ,kWMMMWk'               .oNMWx.   cXMMMMMMMM
MMMMMMMMMXc   .dNMNd.               .lXMMMMXo.      ,KMMMMNl       .dOc                  'x:                'kl                  .dk,         cXMMMNd.    .oXWMMMXl.               .dNMNd.   cXMMMMMMMMM
MMMMMMMMMMXl   .oNMWx.                ,kNMMMW0:.    .dNWMWO,      ;OO,                   lx.                .dk.                  .lOl.        'clc,.   .:0WMMMNk,                .xWMNo.   lXMMMMMMMMMM
MMMMMMMMMMMNo.  .lXMWO,                .cKWMMMNO;.    '::,.     .l0x.                   .xo                  :0c                    ;Ox'              .;ONMMMWKc.                ,OWMXl.  .oNMMMMMMMMMMM
MMMMMMMMMMMMNd.   ;0WMKc.                .oXMMMMNk:.           'xKl.                    :O;                  .kx.                    'xO:           .:kNMMMMXo.                .cKMW0;   .dNMMMMMMMMMMMM
MMMMMMMMMMMMMWk'   'xNMNx.                 'dXMMMMNOc.        :00:                     .xx.                   o0;           ...       .o0o.       .cONMMMMXd'                 .xNMNx'   ,kWMMMMMMMMMMMMM
MMMMMMMMMMMMMMWK:   .lXMW0:                  'dXWMMMWKo'    .oKk'         .:ll;.       ;Ol                    ;0d.        'd0K0d'       :0k,    'oKWMMMWXd'                 .:0WMXl.   :KWMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMXo.   ,kWMNx'                  .o0WMMMMXkc',kXd.         :KWMMNx.      oO,                    .k0,       .xWMMMMk.       'k0l,ckNWMMMW0o.                  'xNMWk,   .oXMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMWO;   .lKWWKl.                  .ckNMMMMWXNNx.          lNMMMM0'     'Ox.        .;:c:'       lXo        cKWMWXl.        :KWNWMMMMNk:.                  .lKWMKl.   ;OWMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMXo.   'xNMW0:.                   ,o0WMMMMWXkc'.       .ck0Od,      cKc        ;0WMMMNd.     '0O'        .:c:.      .'ckXWMMMMW0o,                   .:OWMNx'   .oXMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMW0:.   ;OWMNk;.                   .;dKWMMMMMN0d:'.               .k0'        oWMMMMM0'     .dXc               .':d0NMMMMMWKd;.                   .;kNMWO;    :0WMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMNx,   .c0WMNk;.                    .;d0NMMMMMWNOdc,.           :Kd.        .o0KKKk;       :Xk.          .,cd0XWMMMMMN0d;.                    .;kNMW0c.   ,xNMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMXd.   .c0WMNO:.                     .,lkKWMMMMMMWKOdl;'.    .dX:            ...         .OX:    .';ldOXWMMMMMMWKkl,.                     .:ONMW0c.   .dXMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMWKo.   .cOWMW0l.                       .,lxKNWMMMMMMWNKOxoldXK:..                    ..,kW0ooxOKNWMMMMMMWNKxl;.                       .l0WMWOc.   .oKWMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMWKo.   .:kNMWKd,.                        .':okKNWMMMMMMMMMMWXK0OkkxdddoooooodddxkOO0KXWMMMMMMMMMMWNKko:'.                        .,dKWMNk:.   .oKWMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKo'    ,dKWMNOc.                           .';ldk0XNWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNX0kdl;'.                           .cONMWKd,    'oKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXx,.   .cONMWXx:.                              ..';:lodkO0KKXNNNNWWWWWWNNNNXKK0Okdol:;'..                              .:xXWMNOc.   .,xXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNOc.    ,o0WMWKx:.                                      ....''',,,,,,'''....                                      .:xKWMW0o,    .cONMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd,.   .;d0WMWXkl,.                                                                                        .,lkXWMN0d;.   .,dKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNOl'    .;oONWMN0dc'.                                                                                .'cd0NMMNOo;.    'lONMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNOl'    .'cxKWMWN0dc,.                                                                        .,cd0NWMWKxc'.    'lkXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNOl,.    .;lkKWMMNKko:'.                                                              .':okKNMMWKkl;.    .,lOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN0d:.     .,lx0XWMWNKOdl:'..                                                ..':ldOKNMMWX0xl,.     .:d0NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOo:.     .';lxOXWMMWNX0kdlc;,...                              ...,;cldk0XNWMMWXOxl;..     .:oOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOdc,.      .,:lxOKXWWMMWNNX0Okxdoolcc::::;;;;:::cccloodxkO0XNNWMMWWXKOxo:,.      .,cdOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNKkoc,.       ..,:codkOKXNNWWMMMMMMMMWWMMWWMMMMMMMMWWNNXKOkdoc:,..       .,cokKNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNXOxo:,..         ...',;:ccllooooddddoooollcc:;,'...         ..,:oxOXNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXKOxoc:,'..                                  ..',:coxOKXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNX0Oxoc:,'...                ...',:coxO0XNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
    
    ";

    public string ruleta3 = @"
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNXKOkdol:;,'...                    ...',;:lodkOKXNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNX0xoc;,..            ....................            ..,;cox0XNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWX0xl:,.        ..';:cloxkkO0KKXXXXNNNNNNXXXXKK0Okkddlc:;'..        .':lx0XWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWN0xl;..      .':loxOKXNWWMMMWWNXXKK00OOOOOOOOOO00KKXXNNWWMMWWNXKOxol:'.      ..;lx0NWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOo:'.     .,:ox0XNWMMWNX0kxolc:;,'.....            .....',;:cloxO0XNWMMWNX0xo:,.     .':oOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNOo:.     .,cdOKNMMWNKOxoc;'..                                        ..';coxOKNWMMNKOdc,.     .:oONWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKxc'.    .;lkKNWMWXOxl;'.                                                        .':lxOXWMWNKkl;.     'cxKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd:.    .,lkKWMWN0xl;.                                                                    .;lx0NWMWKkl,.    .:dKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd;.    .:x0NMWN0d:'.                                                                            .':d0NWMN0x:.    .;dKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXx:.    'ckXWMWKxc'.                                                                                    .'cxKWMWXkc.    .:kXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMW0l'    .ckXWMN0o;.                                                                                            .;o0NMWXkc.    'l0NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXx;.   .;xXWMNOo,.                                 ..',;:clooddxxxxxxxxddoolc:;,'..                                 .,oONMWXx:.   .;xXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd'    'o0WMW0o,.                            ..,:ldk0KXNWWMMMMMMMMMMMMMMMMMMMMMMWWNXK0kdlc;..                            .,o0WMW0o'    ,dKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMWKo.   .;xXMMXx:.                         ..;cdkKXWMMMMMMMMMMMMWWNNNNNXXXXNNNNNWWMMMMMMMMMMMMWNKkdc;..                         .:xXWWXx;.   .oKWMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMWKl.   .cONMW0o'                        .,cx0XWMMMMMMMMWXXNW0dlc:;,,''........'',,;:clxXWKKXWWMMMMMMMWX0xc,.                        'o0WMNO:.   .oKWMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMWKo.   .c0WMNOc.                      .,lkKNMMMMMMWNKOdl:,..dNx.                        ;Kk'..,:ldOKNWMMMMMMNKkl,.                      .cONMW0c.   .oKWMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMXd'   .c0WMNk:.                     .cxKWMMMMMWN0xl:'.       ,KK,        .,cll:.         oXc        .':lx0NWMMMMMNKxc'                     .:kNMW0c.   'dXMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMWk;   .:OWMNk;.                    'lkXWMMMMWNOd:'.            .dNl       .dNMMMWK:       .O0'             .':dOXWMMMMWXkl'                    .;kNMWO:.   ;kWMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMWKc.   ,kNMWO:.                   .ckXWMMMMN0d:'                  ;Kk.      .OMMMMMWo       :Ko        .',.       ':d0NMMMMWXkc.                   .:OWMNk,   .cKWMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMNx'   .oXMW0c.                  .;xXWMMMMMXd,.      .:dxo;.        .kK;       'dO00kc.      .d0;      .l0NNXx'        .;kWMMMMMWXx;.                  .c0WMXo.   'xNMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWKc.   :0WMXo.                  .l0NMMMMW0x0K:       .xWMMMNo.        cXo                     'Ox.      ,KMMMMWo         ;OXxd0WMMMMN0l.                  .oXMW0:   .cKWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMWk'   .dNMWO,                  'oKWMMMWXx;. .xKo.     .xWMMMNo.        .OO.                    :0:       .l0NWXx'        cK0:  .;xXWMMMWKo'                  ,OWMNd.   'kWMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMXo.   ;0WMXl.                 'dXMMMMW0l.     .c0x'     .cdxd:.          lK:                   .dk.         .',.        .dKx'      .l0WMMMMXd'                 .lXMW0;   .oXMMMMMMMMMMMMMM
MMMMMMMMMMMMMKc   .lXMWO;                 .dXMMMMNO:.         ,kO;                     'Ox.                  'kl                     'kKl.         .:ONMMMMXd.                 ;OWMXo.   cKMMMMMMMMMMMMM
MMMMMMMMMMMW0;   .xNMNd.                .lKWMMMNk;.            .oOl.                    oO,                  ck,                    ;0O;             .;kNMMMWKl.                .dNMNx.   ;0WMMMMMMMMMMM
MMMMMMMMMMWO'   ,OWMXl.                ;0WMMMWO:.                :Od.                   ;Ol                 .dd.                  .l0d.       'clc,.   .:OWMMMW0;                .lXMWO,   'OWMMMMMMMMMM
MMMMMMMMMWk'   ;0MMK:                .dNMMMWKc.    ,ldo;.         .dk;                  .dx.                ,x;                  .dOc.       cXMMMNd.    .cKWMMMNd.                :KMM0;   'kWMMMMMMMMM
MMMMMMMMWk.   :KMW0,                :0WMMMXd.     lNMMMNd.         .ckc.                 :k;                ld.                 ,kk,        .dWMMMWk.      .dXMMMW0:                ,0WMK:   .kWMMMMMMMM
MMMMMMMWk'   :KMWO,               .oXMMMW0:      .dWMMMWx.           ,xo.                .xo               .dc                 :Oo.          .lk0Oo'         :0WMMMXo.               ,OWMK:   'kWMMMMMMM
MMMMMMWO'   :KMWO'               'kWMMMMXc.       .cxkxl.             .od,                cx.              ;d'               .ok:                            'xNMMMMWk'               'OWMK;   'OWMMMMMM
MMMMMM0;   ;0MM0,               ,0WMMMXkOKkc'                           :x:               'x:              ll               'dd'                          .:xOkldXMMMW0,               ,0MM0;   ;0MMMMMM
MMMMMX:   'OMMK;               ;KMMMM0; .,oO0kc.                         'ol.              lo.            .o,              ;xl.                        .:dkxc'   ;0WMMMK;               ;KMMO'   :XMMMMM
MMMMNo.  .xWMX:               :KMMMWO,     .'lkOxc.                       .co'             ,o'            ;l.            .cd;                       .;okxc.       ,OWMMMK:               :XMWx.  .oNMMMM
MMMWk.  .oNMNo               ;KMMMWO'          'cxOd:.                      ,o;            .l:           .c;            .lo.                     .,oxdc.           'OWMMMK;               oNMNo   .kWMMM
MMMK;   ;KMWk.              ,0MMMWO'              .cxkd:.                    .cc.           ,l.          'c.           'o:.                   .,ldd:.               'OWMMM0,              .kWMK;   ;KMMM
MMWo.  .kMMK,              'OWMMM0,                  .:dxo;.                   ;c.          .c,          ;;           ;l,                   'cdo:.          ,clc'    ,0MMMWO'              ,KMMk.  .oWMM
MM0'   lNMNl              .xWMMMK;    .,;,.             .;odo;.                 'c,          ;:         .:'         .:c.                 'col:.           .oNMMMXc    ;KMMMWd.              lNMNl   '0MM
MNl   '0MMO.              cNMMMNl    ;0NWWKc.              .;lol,.               .;;.        .:.        ';.        .c;                .:ll;.              .kMMMMWd.    lNMMMNc              .OMM0'   lNM
M0'   oWMNc              ,0MMMWx.   .xWMMMMO.                 .,coc,.              ';.        ;,        ,'        ':.              .;cc;.                  'oO0Ol.     .xWMMM0,              cNMWo   '0M
Wo   '0MMO.             .dWMMMK,     'xKXXk;                     .,cc:'.            .;'       .,.      .,.       ,;.            .,::,.                        .         ,KMMMWd.             .OMM0'   oW
K;   cNMNl              ;KMMMWo        ...                           ':::'            ''       ,.      .'      .,'           .,;;,.                                      oWMMMK,              lNMNc   ;K
k.  .kMM0,             .dWMMM0,                                         .;;;.          .'.    .coccccccl:.    .,.         .',;'.                                         ;KMMMWd.             ,KMMx.  .k
l   ,KMMx.             '0MMMMKd:;'..                                       .,;,.        .,;cdOXWWMMMMMMWNXOdc:,.        .','.                                    ..';cldx0NMMMM0'             .xWMK,   l
;   cNMNl              cNMMMNxodxxxxxdolc:,'..                                .','.    .;kNWMMMMMMMMMMMMMMMMWNk;.    .''..                              ..,;cldxxkkkkxolc:oXMMMNc              lNMNc   ;
.  .dWMX;             .dWMMMO.    ...';:clooooollc:;'..                          .....;kNMMMMN0xolcccclokKNMMMMNk;....                         ..,;clooddddolc:,'..       .OMMMWd.             ;XMWd.  .
.  .kMM0'             .OMMMWd.               ...',::ccccc::;;,...                   .dNMMMW0o;;codxkkxdl:;:dKWMMMNd.                  ..,;::cclllcc:;,...                 .dWMMMO.             '0MMk.  .
   '0MMk.             ,KMMMNl                            ..',,;;;;,,,,'...          lNMMMKl':xXNXOkxxkOXNKx;,dXMMMNl         ..',,;;;;;;;;,...                             lNMMMK,             .kMM0'   
   ,KMMx.             :XMMMX:                                       ...''''........:KMMM0;'xNNk:.      .:ONXo'cXMMMKc.....''''''...                              ,loo;.    :XMMMX:             .xMMK,   
   ,KMWd.             cNMMMK;     .,;,.                                        ...'kWMMXc.xWXc.          .oNNo.oNMMWk'..                                        lNMMMNd.   ;KMMMNc             .dWMK;   
   ;XMWd              cNMMMK,    cKWWN0;                                          .kMMMO';KNo.            .kM0,,KMMMk.                                         .dWMMMWk.   ,KMMMNc              dWMX;   
   ;XMWd.             cNMMMK,   .OMMMMMx.                        ..               'OMMWx..:,.             .xMK,,0MMMk.                                          .cxOkl.    ,KMMMNc             .dWMK;   
   ,KMWd.             :XMMMX;    ;kXNKx'                       .:kc       ...,;codxkdc,.                  :XWx.cNMMNd..........                                            ;XMMMX:             .dWMK,   
   '0MMx.             ;XMMMNc      ...                       .:kNNd;:codxO0KK0koc,.         .,;.        'oXWk,,0MMWk.    ....''''',,,,'...                                 cNMMMX;             .xMM0'   
.  .OMMO.             '0MMMWo                        ..',;:ldkkkXWWWWMWNKkoc,.        ..;c,.:0NKkolcclokXN0l':0WMMO,               ..',;;;;::::;;,...                      oWMMM0'             .OMMO.  .
.  .xWMK,             .kMMMMx.            ..',;clloooollclOX0c.cXWNKko:'.        ..;ldkKWWXx:;cok0KXXK0ko:,:kNMMNk:'.                       ..',;:cclllllc:;,'..          .xMMMMk.             ,KMWx.  .
,   oWMX:              oWMMM0, ...,;:lodxxxxddoc:;'..  .;xkc.  ;l:'.        ..;ldxxdl;':kNMMN0dl:::::::clxKWMMNk;. ..''.                              ..,;:loodddddolc:,'.:KMMMWo              :XMWo   ,
c   :XMWo.             ;KMMMW0kOOOOkxol:,'..         .;xkc.            .';lx0XKx:..     .ck0NWMMWNNXXNNWMMWN0xc.      ..,,'.                                   ..',:lodxkkKWMMMX;              oWMX;   c
d.  .OMMO.             .kMMMMXo,'..                .;xkc.         .':ok0NWWXx:.         .'..':ok000KK000ko:'....         .';;'.                                          ,0MMMMk.             .OMMO.  .d
0'  .oWMX:              cNMMMX:                  .;xkc.          .dXWMMWXkc.          .,'      .'......,'      .,.          .,::,.                                       :XMMMNc              :XMWo.  '0
Nc   ;KMWd.             .OMMMMk.               .;kNKo;,,,'''......,oKWWO;            .;.       ,.      .,.      .,.            .;cc;.                       .;ool,      .kWMMMO.             .dWMK;   cN
Wx.  .xWMK;              cXMMMNl       .;c:.   .cooooodddddddddxk00kk0KOo'          ,:.       .,.       ,'       .,,.             .;ll:.                   .dNMMMNl     lNMMMXc              ;KMWx.  .xW
MX;   :XMWd.             .xWMMM0,     :KWMWXl.               .;lol,.......        .:;.        ,'        ':.        ':.               .:oo:.                .kWMMMWo.   ,0MMMWx.             .dWMX:   ;XM
MWx.  .xWMK;              ,0MMMWk.   .xWMMMMO.            .'clc,.                'c,         .;.        .:'         .:,                 .cooc'              .lkkxc.   .kWMMM0,              ;KMWx.  .xWM
MMX:   ;KMWk.              cXMMMWd.   'd0K0x,          .,lol;.                 .:l'          ,;          ;:          .::.                  'cddl'.                   .dNMMMX:              .kWMK;   :XMM
MMMk.  .oNMNl              .oNMMMNl.    ...         .,ldo:.                   .lc.          .:,          .l'           ,l'                    'lxxl,.               .lNMMMNo.              lNMNo.  .kMMM
MMMNo   .kMMK;              .dWMMMXl             .,lxd:.                     ,d:            'c.          .c:            'l:.                     ,lkko;.            lXMMMWd.              ;KMWk.   oNMMM
MMMMK;   ;KMMO.              .xWMMMXl.        .;oxxc.                      .cd,             c:            ;o.            .cl.                      .,okOd;.       .lXMMMWx.              .OMMK;   ;KMMMM
MMMMMO'   cXMWx.              .xWMMMNo.    .;okxl'                        'do.             .l,            .o:              :d;                        .,oOOx:.   .oNMMMWd.              .xWMXc   'OWMMMM
MMMMMWx.  .oNMNo.              .dNMMMNx'.;dOkl'                          ;xl.              :l.             lo.              'dl.                         .;d00xc;xNMMMNd.              .oNMNo.  .xWMMMMM
MMMMMMNo.  .dWMNo.              .lXMMMWX0Oo,.                          .lk:               .o:              ,x;               .od'               .,;,.       .;xXWWMMMXl.              .oNMWd.  .oNMMMMMM
MMMMMMMXl   .xWMNl.               :KWMMMNd.          .;:;.            'xx'                ;d'              .do.               .cxc.            cKWWN0;       .oXMMMW0:               .lNMWx.   lXMMMMMMM
MMMMMMMMXc   .xWMNo.               'kWMMMWk,       .lXWMWK:          cOo.                .oo.               ck,                 ,xo.          .OMMMMWx.     ,kWMMMWk'               .oNMWx.   cXMMMMMMMM
MMMMMMMMMXc   .dNMNd.               .lXMMMMXo.     .OMMMMWx.       .d0c.                 'x:                'kl                  .dk;          ;kXNKx'    .oXWMMMXl.               .dNMNd.   cXMMMMMMMMM
MMMMMMMMMMXl   .oNMWx.                ,kWMMMW0:.    ,xKX0d'       ,kO;                   cx.                .dk.                  .lOl.          ...    .:0WMMMNk,                .xWMNo.   lXMMMMMMMMMM
MMMMMMMMMMMNo.  .lXMWO,                .c0WMMMNO;.    ...       .l0x.                   .xo                  :0c                    ;kx'              .;ONMMMWKc.                ,OWMXl.  .oNMMMMMMMMMMM
MMMMMMMMMMMMNd.   ;0WMKc.                .oXWMMMNk:.           .xKo.                    :O;                  .kk.                    .xO:           .:kNMMMMXo.                .cKMW0;   .xNMMMMMMMMMMMM
MMMMMMMMMMMMMWk'   'xNMNx.                 'dXWMMMNOc.        ;00:                     .dk.                   o0:           .','.     .l0d.       .cONMMMMXd'                 .xNMNx'   ,kWMMMMMMMMMMMMM
MMMMMMMMMMMMMMWK:   .lXMW0:.                 'dXWMMMWKo'    .oKO,        ,oxdc.        ,Ol                    ,0x.         ;ONWN0:      :OO;    'oKWMMMWXd'                 .:0WMXl.   :KMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMXd.   ,kWMNx'                  .o0WMMMMNkc.,kXd.        cXMMMWO'       o0,                    .x0,        .xWMMMMO.      'k0l,ckXMMMMW0o'                  'xNMWk,   .dXMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMWO;   .lKWWKl.                  .:kNMMMMWXNNx.         cXMMMWO'      'Ox.       .;cc:'        cXo         ,kXNNO:        ;KWNWMMMMNkc.                  .lKWMKl.   ;OWMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMXo.   'xNMWO:.                   ,o0WMMMMWXkc'.       ,oxdc.       cKl       ;0WMMWXo.      '00'          .''.     .'ckXWMMMMW0o,                   .:OWMNx'   .oXMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMW0:.   ;ONMNO;.                   .;dKWMMMMMN0d:'.               .k0,       oWMMMMM0'      .dNl               .':d0NMMMMMWKd;.                   .;kNMWO;    :0WMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMNx,   .c0WMNk;.                    .;d0NMMMMMWNOdc,.           ;Kx.       .o0KXKx;        :XO.          .,cd0NWMMMMMN0d;.                    .;kNMW0c.   ,xNMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMXo.   .c0WMNO:.                     .,lkKWMMMMMMWXOdl;'.    .dXc          ....          .OX:    .';ldOKNMMMMMMWKkl,.                     .:ONMW0c.   'dXMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMWKo.   .cOWMW0l.                       .;lxKNWMMMMMMWNKOxoloKK:..                    ..,kW0ooxOKNWMMMMMMWNKxl,.                       .l0WMWOc.   .oKWMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMWKo.   .:kNMWKd,.                        .':okKNWMMMMMMMMMMWNK0OkkxdddoooooodddxkkO0KXWMMMMMMMMMMWNKko:'.                        .,dKWMNk:.   .lKWMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKo'    ,dKWMNOc.                           .';ldk0XNWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNX0kdl;'.                           .cONMWKd,    'oKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXx,.   .cONMWXx:.                              ..';:lodkO0KKXNNNNWWWWWWNNNXXKK0Okdol:;'..                              .:xXWMNOc.   .,xXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNOc.    ,o0WMWKx:.                                      ....''',,,,,,'''....                                      .:xKWMW0o,    .cONMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd,.   .;d0NMWXkl,.                                                                                        .,lkXWMW0d;.   .,dKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNOl'    .;oONMMN0dc'.                                                                                .':d0NMWNOo;.    'lONMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNkl'    .'cxKWMWN0dc,.                                                                        .,cd0NWMWKxc'.    'lkXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOl,.    .;lkKWMMNKko:'.                                                              .':okKNMMWKkl;.    .,lOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN0d:.     .,lx0XWMWNKOdl:'..                                                ..':ldOKNWMWX0xl,.     .:d0NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOo:.     ..;lxOXWMMWNX0kdlc;,...                              ...,;cldk0XNWMMWXOxl;..     .:oOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOdc,.      .,:lxOKXWWMMWNXK0Okxdoolcc::::;;;;:::cccloodxkO0XXNWMMWWXKOxl:,.      .,cdOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNKkoc,.       ..,:codkOKXNNWWMMMMMMMMWWMMMWMMMMMMMMWWNNXKOkdoc:,..       .,:okKNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNXOxo:,..         ...',;:ccllooooddddoooollcc:;,'...         ..,:oxOXNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXKOxoc:,'..                                  ..',:coxOKXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNX0Oxoc:,'...                ...',:coxO0XNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM    
    ";

    public string ruleta2 = @"
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNXKOkdol:;,'...                    ...',;:lodkOKXNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNX0xoc;'..            ....................            ..,;cox0XNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWX0xl:,.        ..';:cloxkkO0KKXXXXNNNNNNXXXXKK0OOkdolc:;'..        .,:lx0XWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWN0xl;..      .':loxOKXNWMMMMWWNXXKK00OOOOOOOOOO00KKXXNWWMMMMWNXKOxol:'.      ..;lx0NWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOo:'.     .,:ox0XNWMMWNX0kxolc:;,'.....            .....',;:cloxO0XNWMMWNX0xo:,.     .':oOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNOo:.     .,cdOKNMMWNKOxoc;'..                                        ..';coxOKNWMMNKOdc,.     .:oONWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKxc'     .;lkKNWMWXOxl:'.                                                        .';lxOXWMWNKkl;.     'cxKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd;.    .,lkKWMWN0xl;.                                                                    .;lx0NWMWKkl,.    .:dKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd;.    .:x0NMWN0d:'.                                                                            .'cd0NWMN0d:.    .;dKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXk:.    .ckXWMWKxc'.                                                                                    .'cxKWMWXkc.    .:xXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMW0l'    .ckXWMN0o;.                                                                                            .;o0NMWXkc.    'l0WMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXx;.   .:xXWMNOo,.                                 ..',;:clooddxxxxxxxxddoolc:;,'..                                 .,oONMWXx;.   .;xXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd'    'o0WMW0o,.                            ..,cldk0KXNWWMMMMMMMMMMMMMMMMMMMMMMWWNXK0kdlc,..                            .,o0WMW0o'    'dKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMWKo.   .;xXMMXx:.                         ..;cdkKNWMMMMMMMMMMMMWWWNNNNXXXXNNNNWWWMMMMMMMMMMMMWNKkdc;..                         .:xXMMXx;.   .oKWMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMWKo.   .:ONMW0o'                        .,cx0XWMMMMMMMMWNKKWNklc:;,,''........'',,;:cloOWNXXWMMMMMMMMWX0xc,.                        'o0WMNOc.   .oKWMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMWKo.   .c0WMNOc.                      .,lkKWMMMMMMWNKkdl:,..'ONc                         oXd..,:ldOKNWMMMMMMWKkl,.                      .cONMW0c.   .oXMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMXd'   .c0WMNk:.                     .cxKWMMMMMWN0xl:'.        lNx.       .:llc;.         .k0,       .':lx0NWMMMMMWKxc.                     .:kNMW0c.   'dXMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMWk;   .:OWMNk;.                    'lkXWMMMMWXOd:'.             '0K,      ;KWMMMWx.        ;Kd.            .':dOXWMMMMWXkl'                    .;kNMWO:.   ;kWMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMWKc.   ,kNMWO:.                   .ckXWMMMMWKd:'       ..         .dXl      lNMMMMM0,       .dK;      .';,.       ':xKNMMMMWXkc.                   .:OWMNk,   .cKWMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMNx'   .dXMW0c.                  .;xXWMMMMMWk;.       .cOKKOc.       ;Kk.     .ck0Okd,        'Ox.     ,kNWWKl.        .,dXMMMMMWXx;.                  .c0WMXo.   'xNMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMKc.   :0WMXo.                  .lONMMMMW0oo0O,        :XMMMMX:       .xK,                     c0:      oWMMMM0,          cKXk0NMMMMNOl.                  .oXMW0:   .cKMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMWk'   .dNMWO,                  'oKWMMMWXx;.  ,k0c       'kNMMNx.        cKl                    .xk.      .dKNXO:         .oXO, .;xXWMMMWKo'                  ,OWMNd.   'kWMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMXo.   ;0WMXl.                 'dXWMMMW0l.      .o0o.      .,::,.         .Ok.                   ,Ol         ....         'kKo.     .l0WMMMMXd'                 .lXMW0;   .oNMMMMMMMMMMMMMM
MMMMMMMMMMMMMKc   .lXMWO;                 .dXWMMMNO:.          :Ox'                     o0;                   ok'                     :00:         .:ONMMMMXd.                 ;OWMXo.   cKMMMMMMMMMMMMM
MMMMMMMMMMMM0;   .xNMNd.                .lKWMMMNk;.             'xO;                    ,Oo                  .ko                    .lKx'            .;kNMMMWKl.                .dNMNx.   ;0MMMMMMMMMMMM
MMMMMMMMMMWO'   ,OWMXl.                :0WMMMWO:.    .,'.        .lOl.                  .dk.                 :k,                   .x0l.     .cdxo;    .:OWMMMW0;                .lXMWO,   'OWMMMMMMMMMM
MMMMMMMMMWk'   ;0MMK:                .dNMMMWKc.    'kXWN0l.        ;kd.                  :O:                .od.                  ;Ok,      .kWMMMNc     .cKWMMMNd.                :KMM0;   'kWMMMMMMMMM
MMMMMMMMWk.   :KMW0,                :0WMMMNd.      oWMMMM0,         .dx,                 .xo.               'x;                 .lOo.       .OWMMMNc       .dNMMMW0:                ,0WMK:   .kWMMMMMMMM
MMMMMMMWk'   :KMWO,               .oNMMMW0;        'xXNN0c.          .cx:                 cx'               cd.                .dO:          .cdxo;          :0WMMMXo.               'OWMK:   'OWMMMMMMM
MMMMMMWO'   ;KMWO'               'kWMMMMWk,.         .''.              ,xl.               'x:              .oc                ,xd'                            :KMMMMWk'               'OWMK:   'OMMMMMMM
MMMMMM0;   ;0MM0,               ,0WMMMXdokKOl'                          .oo.               lo.             ,o.              .ckc.                          .:dOOkXMMMW0,               ,0MM0;   ;0MMMMMM
MMMMMX:   'OMMK;               ;0MMMM0;   'lk0kc.                        .:d;              ,d'             cc              .ox,                         .;dOkl,. ;0MMMMK;               ;KMWO'   cXMMMMM
MMMMNo.  .xWMX:               :KMMMWO,       'ckOxc.                       'o:.            .o:            .l'             'dl.                       .;okxl'      ,OWMMMK:               :XMWx.  .oNMMMM
MMMWk.   oNMNo               ;KMMMWO'           .cxOd:.                     .cl.            :l.           ;c.            ;d:                      .;oxdc.          'OWMMMK;               oNMNo   .kWMMM
MMMK;   ;KMWk.              ,0MMMWO'               .cdkd;.                    ;l'           .l,          .c,           .co.                    .,ldd:.              'OWMMM0,              .kWMK;   ;KMMM
MMWo.  .kMMK,              'OWMMM0,     ...           .:dxo,.                  'c;           ::          ':.          'l:.                  .,ldo:.        .lxxo;    ,0MMMWO'              ,KMMk.  .oWMM
MM0'   lNMNl              .dWMMMK:    :OXXKd.            .:odl,                 .::.         'c.         ;,          ,l,                 .,col;.          'OWMMMNc    ;KMMMWd.              lNMNl   '0MM
MNl   '0MMO.              cNMMMNl    '0MMMMWo               .:ooc'                ,:.        .:'        .;.        .::.                'clc;.             .OWMMMXc     lNMMMNc              .OMM0'   lNM
M0'   oWMNc              ,0MMMWx.    .oXWWNO,                  .;ll:.              .;'        ,;        ',        .:,               ':cc,.                 .cddo,      .xWMMM0,              cNMWo   '0M
Wo   '0MMO.             .dWMMMK,       .;;'.                      .;cc;.            .,,       .;.       ,.       ':.             .;::'.                                 ,KMMMWd.             .OMM0'   oW
K;   cNMNl              ,KMMMWo                                      .,::,.           .,.      ''      .'      .,,.           .;;;'                                      oWMMMK;              lNMNc   ;K
k.  .kMMK,             .dWMMMK;                                         .,;;,.         .'.    .:occcccclc.    .,.          .,;,.                                         ,0MMMWd.             ,0MWx.  .k
l   ,KMMx.             '0MMMWXOxdl:;'..                                    .',,'.        ';cdOXNWMMMMMMWWXOdc;,.        .','.                                       ..';cdKMMMM0'             .xMMK,   l
;   cNMNl              cNMMMXl,;clodxxxddolc;'..                              ..''.    .;kNWMMMMWNXXXXXNWMMMWNk;.    ..''.                                ..',:codxkOOOkkdkNMMMNc              lNMNc   ;
.  .dWMX;             .dWMMMO.        ..';:clloolllc:;'..                         .'..;kNMMMWXOoc::::::::ld0WMMNk;.....                          ..,;cloodxxxddoc:;'...   .OMMMWd.             ;XMWd.  .
.  .kMM0'             .OMMMWd.                  ...,;::cc::::;,'..                  .dNMMMWKo;;lx0KXXXXKOd:,:kNMMNd.                   ..',;:ccllllllc:,'...              .dWMMMO.             '0MMk.  .
   '0MMk.             ,KMMMNl                              ..',,;;,,,,''...         lNMMMNx,,xXN0dl:::cokXN0l'cKMMNl          ..',,;;;:::::;,'..                           cNMMMK,             .kMM0'   
   ,KMMx.             :XMMMX:     ..'.                               .....'........:XMMMWd.:KWO:.        .oXWk';KMMK:.....''''',''...                                      :XMMMX:             .xMMK,   
   ;KMWd.             cNMMMK;    :OXNXk,                                        ..'xWMMM0,,0WO'            cXWd.lNMWk'...                                       .:dkxc.    ;KMMMNc             .dWMK,   
   ;XMWd              cNMMMK,   .OMMMMWx.                                         .kMMMMx.cNNl             .OMO';XMMk.                                         .oNMMMWx.   ,KMMMNc              dWMX;   
   ;KMWd.             cNMMMK,    c0NWNO;                                          .kMMMMk.:NWo             '0MO.:XMMk.                                          lNMMMWx.   ,KMMMNc             .dWMX;   
   ,KMWd.             :NMMMX;     .,,'.                                  ..........dNMMMX:.kWKc           .xWXc.xWMNd........                                   .;odo:.    ;XMMMX:             .dWMK,   
   '0MMk.             ;XMMMNc                                 ..',,;;,,,,,''...    .kWMMM0;'xNNk:..       oNKc.oNMWk.   .....''''',''...                                   cNMMMX;             .kMM0'   
   .OMMO.             '0MMMWo                     ...,;:cccccc::;;'...              ,OMMMMKl,:xXNX0xo,    .:,;xNMMO,             ...',;;;;;:;;,'...                        oWMMM0'             .OMMO.   
.  .xMMK,             .kMMMMk.         ..',;clooodoollc:;'..                       ..;xNMMMW0o:;:lodd:     .oXMMNk:..                     ..',;:ccccllc:;,'..             .xMMMMk.             ,KMMx.  .
,   oWMX:              oWMMMKc',:cloxxkkkxdolc:,...                             ....  .;kNMMMMNKkdllll;.    lNNO;. ..''.                           ..',:cloodddool:;'...  ,0MMMWo              :NMWo   ,
c   ;XMWo              ;XMMMWX0Okxol:;'..                                   ..''.       .ck0NWMMMMMMMMNl    .xK:      .',,.                                 ...,:codxxkkxxOWMMMX;              oWMX:   c
d.  .OMMO.             .kMMMM0;.                                         .',,..         ''..':ok000KK0XK:    'kO'        .,;,.                                        ..,oXMMMMk.             .OMMO.  .d
0'  .oWMX:              cNMMMX:                                       .,;;'.          .,.      '' ....'kO,    ;0x.          .;:;.                                        :XMMMNc              :XMWo.  '0
Nc   ;KMWx.             .OMMMMk.                                   .,::,.            ';.      .,.      ,0x.    cKx.           .':c:'                                    .kMMMMO.             .dWMK;   cN
Wx.  .xWMK;              cXMMMNl        .''.                    .;c:,.             .;;.       ',       .dNo.   .dN0;             .,cl:'                    .:xOko'      lNMMMXc              ;KMWx.  .xM
MX;   :XMWd.             .xWMMM0,     'xXNN0c.               .:lc;.               'c,        .;.        :XX:    .kWXl.              .;loc'.                lNMMMWO'    ,0MMMWx.             .dWMX:   ;XM
MWx.  .xWMK;              ,0MMMWk.    oWMMMMK,            'cll;.                .;c.         ';.        'OM0,    ,0MNx'  ..            .:odl,.             :XMMMWk.   .kWMMM0,              ;KMWx.  .xWM
MMX:   ;KMWk.              :XMMMNd.   'xXWNKl.         'coo:.                  .l:.          ;,         .dWWk.    cXMW0c:ko.              .:ddl,.           'coo:.   .dWMMMXc              .kWMK;   :XMM
MMMk.  .oWMNl              .oNMMMNl.    .,'.       .,ldo:.                    ,o;           .c.          :XMWd.   .oNMMWNWd.                 .cxxo,.                .oNMMMNo.              lNMWo.  .kMMM
MMMNl   .kMMK;              .dWMMMNl            .;oxdc.                     .co'            ::           .OMMXc    .kWNkkXo                     'lkko;.             lXMMMWd.              ;KMMk.   oNMMM
MMMMK;   ;KMMO.              .xWMMMNl.       .;okxc.                       'dl.            .l,        'ldxKMMMK;    'd:.cX0:                       ,okOd;.        .lXMMMWx.              .OMMK;   ;KMMMM
MMMMWO'   cXMWx.              .xWMMMNo.   .:dkxl'                        .:x:              ;l.         .lKWKkxkl.       cKxol.                       .,oOOd;.    .oNMMMWx.              .xWMXc   'OMMMMM
MMMMMWx.  .oNMNo.              .dNMMMNx;:xOkl'                          .ox,              .o:            .o0x;.         oK:.cd,                         .;d00d;.'xNMMMNd.              .oNMNo.  .xWMMMMM
MMMMMMNo.  .dWMNl.              .lXMMMWWKo'                            ;ko.               ,d'              lNKx,        dK,  ;xc.                          .:xKKXWMMMXl.              .oNMWd.  .oNMMMMMM
MMMMMMMNl   .xWMNl.               :0WMMMXl.           .,'.           .lOc.               .ll.              ,kdoOd,     .x0'   'do.            .cdxo,         .xWMMMWK:               .lNMWx.   lNMMMMMMM
MMMMMMMMXc   .xWMNo.               'kWMMMWk,        'xXWN0c.        'xk;                 'x;               .xo..oOd,   .kO'    .ox;          .OWMMMXc       ,kNMMMWk'               .oNMWx.   cXMMMMMMMM
MMMMMMMMMXc   .dNMNd.               .lXMMMMXo.      oWMMMM0,      .cOd.                  lx.                lk'  'oOd' .Ok.      ckl.        'OWMMMNc     .oXMMMMXl.               .dNMNd.   cXMMMMMMMMM
MMMMMMMMMMXl   .oNMWx.                ,kNMMMW0:.    'xXNN0c.     .d0l.                  .xl                 ,Ol    'oOdl0x.       ,kx'        .cdxo;    .:0WMMMNk,                .xWMNo.   lXMMMMMMMMMM
MMMMMMMMMMMNo.  .lXMWO,                .c0WMMMNO;.    .,'.      ;OO;                    ck,                 .xk.     'dKNd.        .xO:               .;ONMMMWKc.                ,OWMXl.  .oNMMMMMMMMMMM
MMMMMMMMMMMMNd.   ;0WMKc.                .oXMMMMNk:.          .oKx'                    .xd.                  c0:       'oc          .o0o.           .:kNMMMMXo.                .cKMW0;   .dNMMMMMMMMMMMM
MMMMMMMMMMMMMWk'   'xNMNx.                 'dXMMMMNOc.       'kKo.                     ;Oc                   '0x.                     :Ok'        .cONMMMMXd'                 .xNMNk'   'kWMMMMMMMMMMMMM
MMMMMMMMMMMMMMWK:   .lXMW0:.                 'dXWMMMWKo'   .cK0:         .:odl'       .dO.                   .d0,         ;xOOx;.      'k0:     'oKWMMMWXd'                  :0WMXl.   :KWMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMXd.   ,kWMNx'                  .oKWMMMMNkc;dXk'         .kWMMMX:      ,0o                     :Ko        ;KMMMMX:       .dKd..ckXMMMMW0o.                  'xNMWk,   .dNMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMWO;   .lKMWKl.                  .ckNMMMMWWWK:          'OWMMMNl      o0;         ':cc,.      '00'       'OWMMW0,        .xNXXWMMMMNkc.                  .lKWMKl.   ;OWMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMXo.   'xNMWO:.                   ,o0WMMMMWXkc'.       'lkkd:.     'Ok.       .dNWMMWO,     .dXc        .:ll:.      .'ckXWMMMMW0o,                   .:0WMNx'   .oXMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMW0:    ;OWMNO;.                   .;dKWMMMMMN0d:'.               lKl        ,KMMMMMNl      :Xk.               .':d0NMMMMMWKd;.                   .;ONMWO;    :0WMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMNx,   .c0WMNk;.                    .;d0NMMMMMWN0dc,.          .k0,         ;kKXKOl.      .OX:           .,cd0NWMMMMMN0d;.                    .;kNMW0c.   ,xNMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMXd.   .c0WMNO:.                     .,lkKWMMMMMMWKOdl;'.    :Xd.           ...          oNd.    .';ldOXWMMMMMMWKkl,.                     .:ONMW0c.   .oXMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMWKo.   .cOWMW0l.                       .;lxKNWMMMMMMWNKOxoo0Nd'..                    ..lNXdldxOKNWMMMMMMWNKxl;.                       .l0WMWOc.   .oKWMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMWKo.   .:kNMWKd,.                        .':okKNWMMMMMMMMMMNXK0OOkxdddoooooodddxkO00KNWMMMMMMMMMMWNKko:'.                        .,dKWMNk:.   .oKWMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKo'    ,dKWMNOc.                           .';ldk0XNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNX0kdl;'.                           .lONMWKd,    'oKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXx,.   .cONMWXx:.                              ..';:lodkO0KKXNNNNWWWWWWNNNXXKK0Okdol:;'..                              .:xXWMNOc.   .,xXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNOc.   .,o0WMWKx:.                                      ....''',,,,,,'''....                                      .:xKWMN0o,    .cONMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd,.   .;d0WMWXkl,.                                                                                        .,lkXWMW0d;.   .,dKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNOl'    .,oONMMN0dc'.                                                                                .'cd0NMMNOo;.    'lONMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNOl'    .'cxKWMWN0dc,.                                                                        .,cd0NWMWKxc'.    'lONWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNOl,.    .;lkKWMMNKko:'.                                                              .':okKNMMWKkl;.    .,lONWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN0d:.     .,lx0XWMMNKOdl:'..                                                ..':ldOKNMMWX0xl,.     .:d0NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOo:.     ..;lxOXWMMWNX0kdlc;,...                              ...,;cldk0XNWMMWXOxl;..     .:oOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOdc,.      .,:lxOKXWWMMWNNX0Okxdoolcc::::;;;;::::ccloodxkO0KXNWMMWWXKOxl:,.      .'cdOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNKkoc,.       ..,:codkOKXNNWWMMMMMMMMMMMMMMMMMMMMMMWWNNX0Okdoc:,..       .,:okKNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOxo:,..         ...',;:ccllooooddddoooollcc:;,'...         ..,:oxOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXKOxoc:,'..                                  ..',:coxOKXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNX0Oxoc:,'...                ...',:loxO0XNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM

    ";

    public string ruleta1 = @"                                                                                                                                                         
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWXKOxdoc:;,'...                    ...',;:codkOKXWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNXOxoc;'..            ....................            ..';cox0KNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWX0xl:,.        ..';:cloxkkO0KKKXXXNNNNNNXXXKKK0OOkxolc:;'..       ..':ox0XWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWN0xc;..      .';ldxOKXNWMMMMWWNXXKK00OOOOOOOOOO00KKXXNWWMMMMWNXKOxol;'.      ..;cx0NWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOo:'.     .,:oxOKNWMMWNX0kxdlc:;,'.....            .....',;:cldxk0XNWMMWNXOxo:,.     .':oOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOd:.     .,cdkKNWWWNKOxoc;'..                                        ..';coxOKNWWWNKkoc,.     .:dOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKxc'.    .,lkKNWWWXOxl;'.                                                        .';lxOXWWWNKkl,.    .'cxKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd:.    .,lkKNMWN0xl;.                                                                    .;lx0NWMNKkl,.    .;dKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd;.    .:d0NMWN0dc'.                                                                            .':d0NWMN0d:.    .;dKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXx:.    'ckXWMWKxc'.                                                                                    .'cxKWMWXkc'    .:xXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNOl'    .ckXWWN0o;.                                                                                            .;o0NWWXkc.    'l0NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXx;.   .:xKWMNOo,.                                 ..',::clooddxxxxxxxxddoollc:;'..                                 .,oONMWKx:.   .;xXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd'    'l0WMW0o,.                            ..,:ldkOKXNWWMMMMMMMMMMMMMMMMMMMMMMWWNXKOkdl:;'.                            .,o0WMW0o'    ,dKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMWWKo.   .;xXWWXx:.                         ..;cdkKXWWMMMMMMMMMMMWWWNNNXXXXXXNNNWWWMMMMMWMMMMMWWXKkdc;..                         .:xXWWXx;.   .oKWWMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMWKo.   .:ONWW0o'                        .,lx0XWMMMMMMMWWXKNWKdlc:;,,''........'',,;:cldKWXKXWMMMMMMMMWX0xl,.                        'o0WWNO:.   .oKWMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMWKo.   .c0WMNOc.                      .,lkKNMMMMMMWNKkdl:,..lXO'                        'O0;..,:ldOKNWMMMMMMNKkl,.                      .cONMW0c.   .oKWMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMXd'   .c0WMNk:.                     'cxKNMMMMMWN0xo:'.       .OX:         'cllc'         :Xd.       .':ox0NWMMMMMNKx:.                     .:kNMW0c.   'dXMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMNk;   .:OWMNk;.                    'lkXWMMMMWXOd:'.             lNd.      .lXWMMWXl.      .dK;             .':dOXWMMMMWXkl'                    .;kNMWO:.   ;kNMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMWKc.   ,kNMWO:.                   .ckXWMMMWN0dc'                  '00'      .xWMMMMWx.      '0k.       ..'.       'cx0NWMMMWXkc.                   .;OWMNk,   .cKWMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMNx'   .oXWW0c.                  .;xKWMMMMMXd;.      .:dxxc.         oXc       .lO00Ol.       cKc       :OXNXk,        .;xNMMMMMWKx;.                  .c0WWXo.   'xWMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWKc.  .:0WWXo.                  .lONMMMMN0dOKo.      .oNMMMWx.        ;Kx.         ..         .xO.      .OMMMMWx.        .xXOx0NMWWWNOl.                  .oXWW0:.  .cKWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMWk'   .dNMWO;                  'oKWMWMWXx;. .l0x.     .oNMMMWx.        .xK,                    ,0o        c0NWNO;        ;OKl. .;xXWMMMWKo'                  ;OWMNd.   'kWMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMNo.   :0WMXl.                 'dXWWMMN0l.      ;OO;     .;oxd:.          :Ko                    oO,         .,,'.       .cKO;      .l0WMMMWKd'                 .lXMW0;   .oNMMMMMMMMMMMMMM
MMMMMMMMMMMMMK:   .oXMWO;                 'dXWMMMNk:.         .d0c.                    .kk.                  .kd.                    .dKd.         .:ONMMMWKd.                 ;OWMXo.   :KMMMMMMMMMMMMM
MMMMMMMMMMMW0;   .xNMNd.                .lKWMMMNk:.            .cOd.                    c0;                  ;O:                    ,k0c.            .:kNMMMWKl.                .dNMNx.   ;0WMMMMMMMMMMM
MMMMMMMMMMWO'   ,OWMXl.                ;OWWMMNO:.                ,kk,                   'Oo                 .ox.                   :0k,       .;cc,.   .:ONMMWWO;                .lXMWO,   'OWMMMMMMMMMM
MMMMMMMMMWk'   ;0WW0:                'dNMMMWKc.   .;oddc.         .ok:                   ok'                'xc                  .o0o.       :0WMWNd.    .cKWMMMNd'                :KWW0;   'kWMMMMMMMMM
MMMMMMMMWk'   :KMWO;                :0WMMMNd.     cXWMMWk.          :ko.                 ,kc                :x'                 .xO:         lNMWMWO'      'dNMMMW0:                ,OWMK:   'kWMMMMMMMM
MMMMMMMWk'   :KMWO'               .oXMMMW0:       lNWMMWk.           .dx'                .dd.              .ol                 ;kx'          .lO00d,        .:OWMMMXo.               ,OWMK:   .kWMMMMMMM
MMMMMMWO'   :KWWO,               'kNMMMMNo.       .;oxdc.             .cx;                :x,              ,d,               .ckl.              ..           .oNMMMMWk'               ,OWWK:   'OMMMMMMM
MMMMMMK;   ;0MM0,               ,0WMMMXxk0Oo;.                          ,dl.              .dc              co.              .ox,                          .;okOddKMMMW0,               ,OWW0;   ;KMMMMMM
MMMMMX:   'OWMK;               ;KWMMM0;  .cx0Oo,.                        .lo.              co.            .o;              ,do.                        .,lkko;.  ;0WMMMK;               ;0MMO'   :XMMMMM
MMMMNo.  .xWMX:               :KMMMWO,      .:xOkl'                        :o,             .o,            ,l.             :x:.                       'lxko,.      ,0WMMMK:               :XMWx.  .oNMMMM
MMMWk.  .oNMNo.              ;KMMMWO'          .:dOkl'                      'o:.            cc            ::            .ld'                      'lxxl,.          'OWMMMK;              .oNMNo.  .kWMMM
MMMK;   :XMWk.              ,0MMMWO'              .;okxc.                    .cc.           ,l.          .c.           'oc.                    .cddl'.              'OWMMM0,              .kWMX:   ;KMMM
MMNo.  .kMMK,              'OWMMM0,                  .;oxdc.                   ,c'          .c;          ;:           ;o,                   .:odc'          .:c:.    ,0MMMWO'              ,KMWk.  .oNMM
MM0'   lNMNl              .dWMMMK:    .;c:'             .,ldo:.                 .:;          ,:.        .;'         .:l.                 .:ooc'           .cKWMWKc    ;KMMMWd.              lNMNl   '0MM
MNl   '0MMO.              cNMMMNl    :0NMWXo.              .,lol;.               .;:.        .:.        .;.        .c;.               .;ll:'              .kMMMMWk.    lNMMMNc              .OMM0'   lNM
MO'   oWMNc              ,0MMMWx.    oWMMWM0'                 .'cll;.              .;.        ,,        ,'        ':'         .:ccc:cd0Od:;,,,''........   'd0K0d'     .xWMMM0,              cNMWo   'OM
Wo   '0MMO.             .dWMMM0,     .o0K0x;                      ':lc,.            .,'       .;.      .,.       ,;.          .:OWWKxoooooddddddddddkK0o'    ...        ,KMMMWd.             .OMM0'   oW
K;   cNMNl              ;KMMMNo        ...                           .;c:'.           ',.      ,.      .'      .;'           .,o0WMNOc.           .lOOc.                 oWMMMK;              lNMNc   ;K
k.  .xMMK,             .dWMMM0,                                         .,:;'          .'.    .coccccccoc.    .,.          'lONMMWX0xc.         .:kkc.                   ;KMMMWd.             ,KMMk.  .k
l   ,KMWx.             '0WMMMXxlc;'..                                      .,,,.        .,;cdOXWWMMMMMMWWXOdc:,.        'lONNXOxl;..          .:kkc.              ..,;cldkXMMMM0'             .xMMK,   l
;   cNMNl              cNMMMXdclddxxxxdolc:,...                               .','.    .;kNWMMNKkxdoodxk0NWMWNk;.  .':lxOOdl;..        ..   .:kkc.       ..,:codxkkOOkxdlcdXMMMNc              lNMNc   ;
.  .dWMX;             .dWMMMO.      ..';:clooooollc:,'..                         .....;kNMMNOl;;:cllllc:;;ckXWMNOddxxoc,.         .,cdk0c..:kOl'.',:clodddxdolc:;'...     .OMMMWd.             ;XMWd.  .
.  .kMM0'             .OMMMWd.                ...';::ccc::::;,'...                  .dXWMWk;,lkXNXK00KXNXOl;;x0koc,.         .,cdOKNWMMXccOXKxlllllc:;'...                .dWMMMO.             '0MMk.  .
   '0MMk.             ,KMMMNc                            ...',;;;;,,,,''...         lXWMNo'c0WKo;......;okx:. .        ..;ldOKNWNXK0O0NN0kc,...                            cNMMMK,             .kMM0'   
   ,KMMx.             :XMMMX:                                       ....'''........:KMMWd.cXNk'                   ..;ldxkkxdol:;'....cKO:.                       'clc,     :XMMMX:             .xMMK,   
   ;KMWd.             cNMMMK;     ':c;.                                         ..'xWMMK;'OMO'               . .:x0X0o;..            ;c.                        cXWMMNo.   ;KMMMNc             .dWMK,   
   ;KMWd              cNMMMK,   .lXWMWK:                                          .kMMM0,,KMx.             ,xk;.OMMMk.                                         .dWMMMWk.   ,KMMMNc              dWMK;   
   ;KMWd.             cNMMMK,   .kMMWMWd.                                         .kMMMX:'kWK;            'OM0',0MMMk.                                          .lO0Oo'    ,KMMMNc             .dWMK;   
   ,KMMd.             :NMMMX;    ,x0K0d.                                  .........oNMMWk';0W0:.         ;OWX:.xWMMNo.........                                             ;XMMMN:             .dWMK,   
   '0MMk.             ;XMMMNc      ...                         ...,,;;,,,,'''...   .kWMMWk,,xNNOo:,,,,:oONNk;'xNMMWk.    ....'''',,,,'...                                  cNMMMX;             .kMM0'   
   .OMMO.             '0MMMWo                       ..',;:ccc::::;,'...             ,OWWMWKl,;lkKXNNNNNKOo:,l0WMWWO'              ..',,;;;;::::;,'..                       oWMMM0'             .OMMO.   
.  .xWMK,             .kMMMMk.           ...,:clloooollc:;'..                      ..;kNMWMWKkl::::::::::cxKWMMMNx:'.                      ...,;:cccllllc:;,'..           .kMMMMk.             ,KMWx.  .
,   oNMN:              oWMMM0;..',;clodxxxxxdol:;'..                            ..... .:kNMMMMMWXK0000KXNWMMWMNk:. ..''.                             ..';:clodddddol:;,...;0MMWWo              :NMWo   ,
c   :XMWd.             ;KMMMWKOOOOkxoc:,'..                                  .''..      .ck0NWMMMMMMMMMMMMWN0kc.      .',,.                                   ..',:lodxxkkKWMMMK;             .dWMX:   c
d.  .OMMO.             .kWMMMKc...                                        .,,'.         ''..':ok000KK000ko:'..'.         .,;;'.                                        ..:0MMMWk.             .OMMO.  .d
0'  .dWMX:              cXMMMX:                                       .';;,.          .,'      .'......,'      .,.          .,::,.                                       :XMMMNc              :XMWd.  'O
Nc   ;KMWd.             .kWMMWk.                                   .'::,.            .;.      .'.      .,.      .,.            .;cc,.                       .,clc'      .kWMMMO.             .xWMK;   cN
Wx.  .xWMK,              cNMMMNc       'clc'                    .,:c;.              ;:.       .,        ;'       .;,              ':ll;.                   .dNWMWK:     lNMMMNc              ,KMWx.  .xW
MX:   :XMWd.             .xWMMM0,    .lXMMWXl.               .,cl:'               .:;         ;'        ,:.        ,;.               'col;.                .OWMMWWo.   ,KMMMWx.             .dWMX:   :XM
MWx.  .xWMK;              ,0MMMWk.   .xWMMMWx.            .;llc'.                ,l'         .;.        .:'         'c'                .,cdo:.              'oO0kc.   .kWMMM0,              ;KMWx.  .xWM
MMX:   ;KMWk.              :XMMMNd.   .oO0Oo.          .;lol,.                 .:l.          ;;          ::          .::.                 .,lxdc.                    .dNMMMX:              .kWMK;   :XMM
MMMO.   oWMNl               oNMMMNl.     .          .;odo,.                   'lc.          .c'          ,l.          .:l.                   .,oxxc'                .oNMMMNo.              lNMWo   .OWMM
MMMNo   .OWMK;              .dWMMMNl             .:dxo;.                     :d;            ,c.          .l:            ,l;                     .;dkxl'             lNMMMWd.              ;KMWO.   oNMMM
MMMMK;   ;KMWO'              .xWMMMXl.        .:dkd:.                      .ld'            .c;            :o.            .lc.                      .:dOkl,.       .lXMMMWx.              'OWMK;   ;KMMMM
MMMMWO'   cXMWx.              .dNMMMNo.    .cxkd:.                        ,dl.             'o'            'd;             .co,                        .:xOOo,.   .oNMMMNd.              .xWMXc   'OWMMMM
MMMMMWx.  .oNMNo.              .dNMMMNx,'cxOxc.                         .ck:.              cl.            .ll.              ;d:.                         .ck0Oo;,xNMMMNd.              .oNMNo.  .xWMMMMM
MMMMMMNo.  .dWMNo.              .lXMMMWXKkc.                           .dx,               .d;              ;x'               'do.               .','.       .cOXNWMMMXl.              .oNMWd.  .oNMMMMMM
MMMMMMMXl   .xNMNl.               :KWMMMNo.         .':c;.            ;kd.                :d.              .xl                .lx;            .cKNWXk,       .oNMMMWK:               .lNMNx.   lXMMMMMMM
MMMMMMMMXc   .xNMNo.               'kWMMMNk,       .dXWMW0;         .lOl.                .dl                lk.                 :kl.          '0MMMMWo.     ,kNMMMWk'               .oNMNx.   cXMMMMMMMM
MMMMMMMMMXc   .dNMNd.               .lKWMMWXo.     '0MMMMWo        'xO:                  ;x,                ;Oc                  ,xx'         .c0NNXx'    .oKWMMWKl.               .dNMNd.   cXMMMMMMMMM
MMMMMMMMMMXl.  .oNMWx.                ,kNMWWW0:.    ;x0KOl.       :Ox'                   ox.                .xx.                  .oOc          .''.    .:0WMMWNk,                .xWMNo.  .lXMMMMMMMMMM
MMMMMMMMMMMNo.  .lXWWO;                .c0WMMMNO:.    ..        .dKo.                   'kc                  cO;                   .cOd.              .;ONMMWW0c.                ,OWWXl.  .oNMMMMMMMMMMM
MMMMMMMMMMMMNx.   ;0WWKc.                .oKWMMMNk:.           ,O0c                     lk'                  'Od.                    ;kk;           .:kNMMMWKo.                .cKWW0;   .xNMMMMMMMMMMMM
MMMMMMMMMMMMMWk'   'kNMNx.                 'dXWWMMNOc.       .cKO,                     .kd.                  .x0,           ..'.      .x0l.       .cONMMMWXd'                 .xNMNk'   'kWMMMMMMMMMMMMM
MMMMMMMMMMMMMMMK:   .lKMW0:.                 'dKWWMWWKo'    'xXx.       .:dxxc.        :0:                    :Ko          :OXNXk,     .l0x'    ,o0WWWWWXd'                 .:0WMKl.   :KMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMNo.   ,kWMNx'                  'o0WWMMWXkc':0Kl.       .oNMMMWx.      .xO.                    .OO.        .OMMMMWx.      ;OO:'ckNWMMWW0l'                  'xNMWk,   .oNMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMWO;   .lKWWKl.                  .:kXWMMMWNNNo.        .oNMMMWx.      ;0o        .;cc;.        oXc         :0NWNO;        cKNNWMMMWXkc.                  .lKWWKl.   ;OWMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMXo.   'xNMW0:.                   ,o0NMMMMWXkc'.      .;oxd:.       oK;       cKWMMWKc       ;Kk.         .','.     .'ckKWMMMMN0o,                   .:0WMNx'   .oXMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMWO:.   ;ONMNk;.                   .;dKWWMMMWNOd:'.               '0k.      .xWMMMMWx.      .kX;               .':dONWMMMWN0d;.                   .;kNMNk;.  .:OWMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMNx,   .cOWMNk;.                    .;o0NMMMWMWNOdc,.           lXl        'd0XX0d'        lNx.          .,cd0NWMMMMMN0o;.                    .;kNMWOc.   ,xNMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMWXd.   .c0WMNk:.                     .,cxKNMMMMMMWXOdl;'.    .kK,          ....          ,KK,    .';ldOXWWMMMMMNKxl,.                     .:kNMW0c.   .dXWMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMWKo.   .cONMW0l.                       .,lxKNWMMMMMMWNKOxolxN0;..                    ..;ONOodxOKNWMMMMMWWNKxl;.                       .l0WMNOc.   .oKWMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMWKo.   .:kNWWKd,.                        .':okKNWMMMMMWMMMMWXK0OOkxdddoooooodddxkOO0KXWMMMMMMMMMMWNKko:'.                        .,dKWWNk:.   .o0WMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKo'   .,dKWMNOc.                           .';cdkOKNWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWMMWWNKOkdc;'.                           .cONMWKd,.   'oKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXx,.   .cONWWXx:.                               .';:lodxO0KXXNNNWWWWWWWWNNNXXK0Oxdol:;'.                               .:xXWWNOc.   .,dXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNkc.   .,o0NMWKx:.                                      ....''',,,,,,'''....                                      .:xKWMN0o,.   .cONWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd,.   .;d0NWWXkl,.                                                                                        .,lkXWWN0d;.   .,dKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNOl'    .;o0NWWN0dc'.                                                                                .'cd0NWWNOo;.    'lONMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXkl'    .'cxKNMWX0dc,.                                                                        .,cd0XWMNKxc'.    'lOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOl,.    .;lkKWMWNKko:'.                                                              .':okKNWMWKkl;.    .,lOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN0d:.     .,lx0XWMWNKOdl:'..                                                ..':ldOKNWMWX0xl,.     .:d0NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOo:.     .';lx0XWMMWNX0kdlc;,...                              ...,;cldk0XNWMMNX0xl;'.     .:oOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOdc,.      .,:lxOKXWWMMWWXK0Okxdoolcc::::;;;;::::ccloodxkO0XNWWMMWWXKOxl:,..     .,cdOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNKko:,.       ..,:codkOKXXNWWMMMMMMMWWWWWWWWMMMMMMMWWNXXKOkdoc:,..       .,cokKNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNKOxl:,..         ...',;:ccllooooddddoooollcc:;,'...         ..,:lxOKNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWMMMWNXKOxoc:,'..                                  ..',:coxk0XWMMMMWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWMMMMMMMMMMMWNXKOxoc:,'...                ...',:coxOKXNWMMMMMMMMMMMWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                                                                                                                                                                                                                                                                        
    ";

    public string primerOpcion = @"

    ███╗   ███╗ ██████╗ ███████╗████████╗██╗     ██╗███████╗████████╗ █████╗     ██████╗ ███████╗   ███████╗███████╗████████╗██╗   ██╗██████╗ ██╗ █████╗ ███╗   ██╗████████╗███████╗███████╗     
    ████╗ ████║██╔═══██╗██╔════╝╚══██╔══╝██║     ██║██╔════╝╚══██╔══╝██╔══██╗    ██╔══██╗██╔════╝   ██╔════╝██╔════╝╚══██╔══╝██║   ██║██╔══██╗██║██╔══██╗████╗  ██║╚══██╔══╝██╔════╝██╔════╝     
    ██╔████╔██║██║   ██║███████╗   ██║   ██║     ██║███████╗   ██║   ███████║    ██║  ██║█████╗     █████╗  ███████╗   ██║   ██║   ██║██║  ██║██║███████║██╔██╗ ██║   ██║   █████╗  ███████╗     
    ██║╚██╔╝██║██║   ██║╚════██║   ██║   ██║     ██║╚════██║   ██║   ██╔══██║    ██║  ██║██╔══╝     ██╔══╝  ╚════██║   ██║   ██║   ██║██║  ██║██║██╔══██║██║╚██╗██║   ██║   ██╔══╝  ╚════██║     
    ██║ ╚═╝ ██║╚██████╔╝███████║   ██║██╗███████╗██║███████║   ██║   ██║  ██║    ██████╔╝███████╗   ███████╗███████║   ██║   ╚██████╔╝██████╔╝██║██║  ██║██║ ╚████║   ██║   ███████╗███████║     
    ╚═╝     ╚═╝ ╚═════╝ ╚══════╝   ╚═╝╚═╝╚══════╝╚═╝╚══════╝   ╚═╝   ╚═╝  ╚═╝    ╚═════╝ ╚══════╝   ╚══════╝╚══════╝   ╚═╝    ╚═════╝ ╚═════╝ ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝╚══════╝
    
    ";

    public string segundaOpcion = @"

    ███╗   ███╗ ██████╗ ███████╗████████╗██╗     ██╗███████╗████████╗ █████╗     ██████╗ ███████╗    ██████╗  ██████╗ ██╗     ███████╗███████╗
    ████╗ ████║██╔═══██╗██╔════╝╚══██╔══╝██║     ██║██╔════╝╚══██╔══╝██╔══██╗    ██╔══██╗██╔════╝    ██╔══██╗██╔═══██╗██║     ██╔════╝██╔════╝
    ██╔████╔██║██║   ██║███████╗   ██║   ██║     ██║███████╗   ██║   ███████║    ██║  ██║█████╗      ██████╔╝██║   ██║██║     █████╗  ███████╗
    ██║╚██╔╝██║██║   ██║╚════██║   ██║   ██║     ██║╚════██║   ██║   ██╔══██║    ██║  ██║██╔══╝      ██╔══██╗██║   ██║██║     ██╔══╝  ╚════██║
    ██║ ╚═╝ ██║╚██████╔╝███████║   ██║██╗███████╗██║███████║   ██║   ██║  ██║    ██████╔╝███████╗    ██║  ██║╚██████╔╝███████╗███████╗███████║
    ╚═╝     ╚═╝ ╚═════╝ ╚══════╝   ╚═╝╚═╝╚══════╝╚═╝╚══════╝   ╚═╝   ╚═╝  ╚═╝    ╚═════╝ ╚══════╝    ╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚══════╝╚══════╝                                                                                                                                    
    
    ";
    
    public string terceraOpcion = @"

    ███████╗██╗     ███████╗ ██████╗ ██╗██████╗     ███████╗███████╗████████╗██╗   ██╗██████╗ ██╗ █████╗ ███╗   ██╗████████╗███████╗      █████╗ ██╗          █████╗ ███████╗ █████╗ ██████╗                                                                             
    ██╔════╝██║     ██╔════╝██╔════╝ ██║██╔══██╗    ██╔════╝██╔════╝╚══██╔══╝██║   ██║██╔══██╗██║██╔══██╗████╗  ██║╚══██╔══╝██╔════╝     ██╔══██╗██║         ██╔══██╗╚══███╔╝██╔══██╗██╔══██╗                                                                            
    █████╗  ██║     █████╗  ██║  ███╗██║██████╔╝    █████╗  ███████╗   ██║   ██║   ██║██║  ██║██║███████║██╔██╗ ██║   ██║   █████╗       ███████║██║         ███████║  ███╔╝ ███████║██████╔╝                                                                            
    ██╔══╝  ██║     ██╔══╝  ██║   ██║██║██╔══██╗    ██╔══╝  ╚════██║   ██║   ██║   ██║██║  ██║██║██╔══██║██║╚██╗██║   ██║   ██╔══╝       ██╔══██║██║         ██╔══██║ ███╔╝  ██╔══██║██╔══██╗                                                                            
    ███████╗███████╗███████╗╚██████╔╝██║██║  ██║    ███████╗███████║   ██║   ╚██████╔╝██████╔╝██║██║  ██║██║ ╚████║   ██║   ███████╗     ██║  ██║███████╗    ██║  ██║███████╗██║  ██║██║  ██║                                                                            
    ╚══════╝╚══════╝╚══════╝ ╚═════╝ ╚═╝╚═╝  ╚═╝    ╚══════╝╚══════╝   ╚═╝    ╚═════╝ ╚═════╝ ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝     ╚═╝  ╚═╝╚══════╝    ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝                                                                                                                                                                                                                                                                                                                    
     
    ";

    public string cuartaOpcion = @"
    
    ███████╗ █████╗ ██╗     ██╗██████╗ 
    ██╔════╝██╔══██╗██║     ██║██╔══██╗
    ███████╗███████║██║     ██║██████╔╝
    ╚════██║██╔══██║██║     ██║██╔══██╗
    ███████║██║  ██║███████╗██║██║  ██║
    ╚══════╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═╝
                                   
    ";

    public void MensajeDeBienvenida(){
        Console.WriteLine(@"

  /$$$$$$            /$$                 /$$                                               /$$ /$$                       /$$                                         /$$                                                               /$$$$$$            /$$           /$$   /$$    
 /$$__  $$          | $$                | $$                                              | $$|__/                      | $$                                        |__/                                                              /$$__  $$          |__/          | $$  / $$    
| $$  \__/  /$$$$$$ | $$  /$$$$$$       | $$  /$$$$$$   /$$$$$$$       /$$    /$$ /$$$$$$ | $$ /$$  /$$$$$$  /$$$$$$$  /$$$$$$    /$$$$$$   /$$$$$$$        /$$$$$$  /$$  /$$$$$$  /$$$$$$  /$$$$$$$         /$$$$$$  /$$$$$$$       | $$  \__/  /$$$$$$  /$$ /$$$$$$$ |  $$/ $$/    
|  $$$$$$  /$$__  $$| $$ /$$__  $$      | $$ /$$__  $$ /$$_____/      |  $$  /$$/|____  $$| $$| $$ /$$__  $$| $$__  $$|_  $$_/   /$$__  $$ /$$_____/       /$$__  $$| $$ /$$__  $$|____  $$| $$__  $$       /$$__  $$| $$__  $$      |  $$$$$$  /$$__  $$| $$| $$__  $$ \  $$$$/     
 \____  $$| $$  \ $$| $$| $$  \ $$      | $$| $$  \ $$|  $$$$$$        \  $$/$$/  /$$$$$$$| $$| $$| $$$$$$$$| $$  \ $$  | $$    | $$$$$$$$|  $$$$$$       | $$  \ $$| $$| $$  \__/ /$$$$$$$| $$  \ $$      | $$$$$$$$| $$  \ $$       \____  $$| $$  \ $$| $$| $$  \ $$  >$$  $$     
 /$$  \ $$| $$  | $$| $$| $$  | $$      | $$| $$  | $$ \____  $$        \  $$$/  /$$__  $$| $$| $$| $$_____/| $$  | $$  | $$ /$$| $$_____/ \____  $$      | $$  | $$| $$| $$      /$$__  $$| $$  | $$      | $$_____/| $$  | $$       /$$  \ $$| $$  | $$| $$| $$  | $$ /$$/\  $$    
|  $$$$$$/|  $$$$$$/| $$|  $$$$$$/      | $$|  $$$$$$/ /$$$$$$$/         \  $/  |  $$$$$$$| $$| $$|  $$$$$$$| $$  | $$  |  $$$$/|  $$$$$$$ /$$$$$$$/      |  $$$$$$$| $$| $$     |  $$$$$$$| $$  | $$      |  $$$$$$$| $$  | $$      |  $$$$$$/| $$$$$$$/| $$| $$  | $$| $$  \ $$ /$$
 \______/  \______/ |__/ \______/       |__/ \______/ |_______/           \_/    \_______/|__/|__/ \_______/|__/  |__/   \___/   \_______/|_______/        \____  $$|__/|__/      \_______/|__/  |__/       \_______/|__/  |__/       \______/ | $$____/ |__/|__/  |__/|__/  |__/|__/
                                                                                                                                                           /$$  \ $$                                                                           | $$                                  
                                                                                                                                                          |  $$$$$$/                                                                           | $$                                  
                                                                                                                                                           \______/                                                                            |__/                                  
       /$$$$$$$$                        /$$                           /$$                                                           /$$                           /$$                   /$$                     /$$                 /$$           /$$$$                              
      |__  $$__/                       | $$                          | $$                                                          | $$                          | $$                  | $$                    | $$                | $$          /$$  $$                             
         | $$  /$$$$$$  /$$$$$$$   /$$$$$$$  /$$$$$$   /$$$$$$$      | $$  /$$$$$$         /$$$$$$$ /$$   /$$  /$$$$$$   /$$$$$$  /$$$$$$    /$$$$$$         /$$$$$$$  /$$$$$$        /$$$$$$   /$$   /$$      | $$  /$$$$$$   /$$$$$$$  /$$$$$$|__/\ $$                             
         | $$ /$$__  $$| $$__  $$ /$$__  $$ /$$__  $$ /$$_____/      | $$ |____  $$       /$$_____/| $$  | $$ /$$__  $$ /$$__  $$|_  $$_/   /$$__  $$       /$$__  $$ /$$__  $$      |_  $$_/  | $$  | $$      | $$ |____  $$ /$$__  $$ /$$__  $$   /$$/                             
         | $$| $$$$$$$$| $$  \ $$| $$  | $$| $$  \__/|  $$$$$$       | $$  /$$$$$$$      |  $$$$$$ | $$  | $$| $$$$$$$$| $$  \__/  | $$    | $$$$$$$$      | $$  | $$| $$$$$$$$        | $$    | $$  | $$      | $$  /$$$$$$$| $$  | $$| $$  \ $$  /$$/                              
         | $$| $$_____/| $$  | $$| $$  | $$| $$       \____  $$      | $$ /$$__  $$       \____  $$| $$  | $$| $$_____/| $$        | $$ /$$| $$_____/      | $$  | $$| $$_____/        | $$ /$$| $$  | $$      | $$ /$$__  $$| $$  | $$| $$  | $$ |__/                               
         | $$|  $$$$$$$| $$  | $$|  $$$$$$$| $$       /$$$$$$$/      | $$|  $$$$$$$       /$$$$$$$/|  $$$$$$/|  $$$$$$$| $$        |  $$$$/|  $$$$$$$      |  $$$$$$$|  $$$$$$$        |  $$$$/|  $$$$$$/      | $$|  $$$$$$$|  $$$$$$$|  $$$$$$/  /$$                               
         |__/ \_______/|__/  |__/ \_______/|__/      |_______/       |__/ \_______/      |_______/  \______/  \_______/|__/         \___/   \_______/       \_______/ \_______/         \___/   \______/       |__/ \_______/ \_______/ \______/  |__/                                                                                                                   
        ");
    }                                                                   
}