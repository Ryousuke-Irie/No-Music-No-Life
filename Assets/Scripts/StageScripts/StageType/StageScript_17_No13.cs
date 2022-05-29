using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScript_17_No13 : StageScript
{
    public GameObject enemyTypeA;
    public GameObject enemyTypeB;
    public GameObject obstacleTypeA;

    private int Max = 0;

    public override void SetStickData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;

        float bpm = 150.0f;
        float sp = 0.10f;
        float p = 30 / bpm;
        float t = 1.0f;
        float g = - 1.5f;    
        // 誤差
                             
        // Stickコピペゾーン --------------------
                             
        //185から201
        //237  243
        //253  261
        //290から307

        //SetStick(num++, (sp + (p * (t * 0))) * vel);
        //SetStick(num++, (sp + (p * (t * 1))) * vel);
        //SetStick(num++, (sp + (p * (t * 2))) * vel);
        //SetStick(num++, (sp + (p * (t * 3))) * vel);
        //SetStick(num++, (sp + (p * (t * 4))) * vel);
        //SetStick(num++, (sp + (p * (t * 5))) * vel);
        //SetStick(num++, (sp + (p * (t * 6))) * vel);
        //SetStick(num++, (sp + (p * (t * 7))) * vel);
        //SetStick(num++, (sp + (p * (t * 8))) * vel);
        SetStick(num++, (sp + (p * (t * (9 + g)))) * vel);
		//SetStick(num++, (sp + (p * (t (* 10))) * vel);
  //      SetStick(num++, (sp + (p * (t (* 11))) * vel);
  //      SetStick(num++, (sp + (p * (t (* 12))) * vel);
        SetStick(num++, (sp + (p * (t * (13 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 14))) * vel);
        //SetStick(num++, (sp + (p * (t (* 15))) * vel);
        //SetStick(num++, (sp + (p * (t (* 16))) * vel);
        SetStick(num++, (sp + (p * (t * (17 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 18))) * vel);
        //SetStick(num++, (sp + (p * (t (* 19))) * vel);
        //SetStick(num++, (sp + (p * (t (* 20))) * vel);
        SetStick(num++, (sp + (p * (t * (21 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 22))) * vel);
        //SetStick(num++, (sp + (p * (t (* 23))) * vel);
        //SetStick(num++, (sp + (p * (t (* 24))) * vel);
        SetStick(num++, (sp + (p * (t * (25 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 26))) * vel);
        //SetStick(num++, (sp + (p * (t (* 27))) * vel);
        //SetStick(num++, (sp + (p * (t (* 28))) * vel);
        SetStick(num++, (sp + (p * (t * (29 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 30))) * vel);
        SetStick(num++, (sp + (p * (t * (31 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 32))) * vel);
        SetStick(num++, (sp + (p * (t * (33 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 34))) * vel);
        SetStick(num++, (sp + (p * (t * (35 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 36))) * vel);
        SetStick(num++, (sp + (p * (t * (37 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 38))) * vel);
        SetStick(num++, (sp + (p * (t * (39 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 40))) * vel);
        SetStick(num++, (sp + (p * (t * (41 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 42))) * vel);
        SetStick(num++, (sp + (p * (t * (43 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 44))) * vel);
        SetStick(num++, (sp + (p * (t * (45 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 46))) * vel);
        SetStick(num++, (sp + (p * (t * (47 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 48))) * vel);
        SetStick(num++, (sp + (p * (t * (49 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 50))) * vel);
        SetStick(num++, (sp + (p * (t * (51 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 52))) * vel);
        SetStick(num++, (sp + (p * (t * (53 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 54))) * vel);
        SetStick(num++, (sp + (p * (t * (55 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 56))) * vel);
        SetStick(num++, (sp + (p * (t * (57 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 58))) * vel);
        SetStick(num++, (sp + (p * (t * (59 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 60))) * vel);
        SetStick(num++, (sp + (p * (t * (61 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 62))) * vel);
        SetStick(num++, (sp + (p * (t * (63 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 64))) * vel);
        SetStick(num++, (sp + (p * (t * (65 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 66))) * vel);
        SetStick(num++, (sp + (p * (t * (67 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 68))) * vel);
        SetStick(num++, (sp + (p * (t * (69 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 70))) * vel);
        SetStick(num++, (sp + (p * (t * (71 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 72))) * vel);
        SetStick(num++, (sp + (p * (t * (73 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 74))) * vel);
        SetStick(num++, (sp + (p * (t * (75 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 76))) * vel);
        SetStick(num++, (sp + (p * (t * (77 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 78))) * vel);
        SetStick(num++, (sp + (p * (t * (79 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 80))) * vel);
        SetStick(num++, (sp + (p * (t * (81 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 82))) * vel);
        SetStick(num++, (sp + (p * (t * (83 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 84))) * vel);
        SetStick(num++, (sp + (p * (t * (85 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 86))) * vel);
        SetStick(num++, (sp + (p * (t * (87 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 88))) * vel);
        SetStick(num++, (sp + (p * (t * (89 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 90))) * vel);
        SetStick(num++, (sp + (p * (t * (91 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 92))) * vel);
        SetStick(num++, (sp + (p * (t * (93 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 94))) * vel);
        SetStick(num++, (sp + (p * (t * (95 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 96))) * vel);
        SetStick(num++, (sp + (p * (t * (97 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 98))) * vel);
        SetStick(num++, (sp + (p * (t * (99 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 100))) * vel);
        SetStick(num++, (sp + (p * (t * (101 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 102))) * vel);
        SetStick(num++, (sp + (p * (t * (103 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 104))) * vel);
        SetStick(num++, (sp + (p * (t * (105 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 106))) * vel);
        SetStick(num++, (sp + (p * (t * (107 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 108))) * vel);
        SetStick(num++, (sp + (p * (t * (109 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 110))) * vel);
        SetStick(num++, (sp + (p * (t * (111 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 112))) * vel);
        SetStick(num++, (sp + (p * (t * (113 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 114))) * vel);
        SetStick(num++, (sp + (p * (t * (115 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 116))) * vel);
        SetStick(num++, (sp + (p * (t * (117 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 118))) * vel);
        SetStick(num++, (sp + (p * (t * (119 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 120))) * vel);
        SetStick(num++, (sp + (p * (t * (121 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 122))) * vel);
        SetStick(num++, (sp + (p * (t * (123 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 124))) * vel);
        SetStick(num++, (sp + (p * (t * (125 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 126))) * vel);
        SetStick(num++, (sp + (p * (t * (127 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 128))) * vel);
        SetStick(num++, (sp + (p * (t * (129 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 130))) * vel);
        SetStick(num++, (sp + (p * (t * (131 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 132))) * vel);
        SetStick(num++, (sp + (p * (t * (133 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 134))) * vel);
        SetStick(num++, (sp + (p * (t * (135 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 136))) * vel);
        SetStick(num++, (sp + (p * (t * (137 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 138))) * vel);
        SetStick(num++, (sp + (p * (t * (139 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 140))) * vel);
        SetStick(num++, (sp + (p * (t * (141 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 142))) * vel);
        SetStick(num++, (sp + (p * (t * (143 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 144))) * vel);
        SetStick(num++, (sp + (p * (t * (145 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 146))) * vel);
        SetStick(num++, (sp + (p * (t * (147 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 148))) * vel);
        SetStick(num++, (sp + (p * (t * (149 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 150))) * vel);
        SetStick(num++, (sp + (p * (t * (151 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 152))) * vel);
        SetStick(num++, (sp + (p * (t * (153 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 154))) * vel);
        SetStick(num++, (sp + (p * (t * (155 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 156))) * vel);
        SetStick(num++, (sp + (p * (t * (157 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 158))) * vel);
        SetStick(num++, (sp + (p * (t * (159 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 160))) * vel);
        SetStick(num++, (sp + (p * (t * (161 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 162))) * vel);
        SetStick(num++, (sp + (p * (t * (163 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 164))) * vel);
        SetStick(num++, (sp + (p * (t * (165 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 166))) * vel);
        SetStick(num++, (sp + (p * (t * (167 + g)))) * vel);
        SetStick(num++, (sp + (p * (t * (168 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 169))) * vel);
        SetStick(num++, (sp + (p * (t * (170 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 171))) * vel);
        SetStick(num++, (sp + (p * (t * (172 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 173))) * vel);
        SetStick(num++, (sp + (p * (t * (174 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 175))) * vel);
        SetStick(num++, (sp + (p * (t * (176 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 177))) * vel);
        //SetStick(num++, (sp + (p * (t (* 178))) * vel);
        SetStick(num++, (sp + (p * (t * (179 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 180))) * vel);
        SetStick(num++, (sp + (p * (t * (181 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 182))) * vel);
        SetStick(num++, (sp + (p * (t * (183 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 184))) * vel);


        SetStick(num++, (sp + (p * (t * (185 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 186))) * vel);
        SetStick(num++, (sp + (p * (t * (187 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 188))) * vel);
        SetStick(num++, (sp + (p * (t * (189 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 190))) * vel);
        SetStick(num++, (sp + (p * (t * (191 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 192))) * vel);
        SetStick(num++, (sp + (p * (t * (193 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 194))) * vel);
        SetStick(num++, (sp + (p * (t * (195 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 196))) * vel);
        SetStick(num++, (sp + (p * (t * (197 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 198))) * vel);
        SetStick(num++, (sp + (p * (t * (199 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 200))) * vel);
        SetStick(num++, (sp + (p * (t * (201 + g)))) * vel);


        //SetStick(num++, (sp + (p * (t (* 202))) * vel);
        SetStick(num++, (sp + (p * (t * (203 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 204))) * vel);
        SetStick(num++, (sp + (p * (t * (205 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 206))) * vel);
        SetStick(num++, (sp + (p * (t * (207 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 208))) * vel);
        SetStick(num++, (sp + (p * (t * (209 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 210))) * vel);
        SetStick(num++, (sp + (p * (t * (211 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 212))) * vel);
        SetStick(num++, (sp + (p * (t * (213 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 214))) * vel);
        SetStick(num++, (sp + (p * (t * (215 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 216))) * vel);
        SetStick(num++, (sp + (p * (t * (217 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 218))) * vel);
        SetStick(num++, (sp + (p * (t * (219 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 220))) * vel);
        SetStick(num++, (sp + (p * (t * (221 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 222))) * vel);
        SetStick(num++, (sp + (p * (t * (223 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 224))) * vel);
        SetStick(num++, (sp + (p * (t * (225 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 226))) * vel);
        SetStick(num++, (sp + (p * (t * (227 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 228))) * vel);
        SetStick(num++, (sp + (p * (t * (229 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 230))) * vel);
        SetStick(num++, (sp + (p * (t * (231 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 232))) * vel);
        SetStick(num++, (sp + (p * (t * (233 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 234))) * vel);
        SetStick(num++, (sp + (p * (t * (235 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 236))) * vel);
       
        SetStick(num++, (sp + (p * (t * (237 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 238))) * vel);
        SetStick(num++, (sp + (p * (t * (239 + g)))) * vel);
       //SetStick(num++, (sp + (p * (t (* 240))) * vel);
        SetStick(num++, (sp + (p * (t * (241 + g)))) * vel);
       // SetStick(num++, (sp + (p * (t (* 242))) * vel);
        SetStick(num++, (sp + (p * (t * (243 + g)))) * vel);
       
        //SetStick(num++, (sp + (p * (t (* 244))) * vel);
        SetStick(num++, (sp + (p * (t * (245 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 246))) * vel);
        SetStick(num++, (sp + (p * (t * (247 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 248))) * vel);
        SetStick(num++, (sp + (p * (t * (249 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 250))) * vel);
        SetStick(num++, (sp + (p * (t * (251 + g)))) * vel);
       
      
        //SetStick(num++, (sp + (p * (t (* 252))) * vel);
        SetStick(num++, (sp + (p * (t * (253 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 254))) * vel);
        SetStick(num++, (sp + (p * (t * (255 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 256))) * vel);
        SetStick(num++, (sp + (p * (t * (257 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 258))) * vel);
        SetStick(num++, (sp + (p * (t * (259 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 260))) * vel);
        SetStick(num++, (sp + (p * (t * (261 + g)))) * vel);
        
        //SetStick(num++, (sp + (p * (t (* 262))) * vel);
        SetStick(num++, (sp + (p * (t * (263 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 264))) * vel);
        SetStick(num++, (sp + (p * (t * (265 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 266))) * vel);
        SetStick(num++, (sp + (p * (t * (267 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 268))) * vel);
        SetStick(num++, (sp + (p * (t * (269 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 270))) * vel);
        SetStick(num++, (sp + (p * (t * (271 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 272))) * vel);
        SetStick(num++, (sp + (p * (t * (273 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 274))) * vel);
        SetStick(num++, (sp + (p * (t * (275 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 276))) * vel);
        SetStick(num++, (sp + (p * (t * (277 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 278))) * vel);
        SetStick(num++, (sp + (p * (t * (279 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 280))) * vel);
        SetStick(num++, (sp + (p * (t * (281 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 282))) * vel);
        SetStick(num++, (sp + (p * (t * (283 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 284))) * vel);
        SetStick(num++, (sp + (p * (t * (285 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 286))) * vel);
        SetStick(num++, (sp + (p * (t * (287 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 288))) * vel);
        SetStick(num++, (sp + (p * (t * (289 + g)))) * vel);
        

        //SetStick(num++, (sp + (p * (t (* 290))) * vel);
        SetStick(num++, (sp + (p * (t * (291 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 292))) * vel);
        SetStick(num++, (sp + (p * (t * (293 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 294))) * vel);
        SetStick(num++, (sp + (p * (t * (295 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 296))) * vel);
        SetStick(num++, (sp + (p * (t * (297 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 298))) * vel);
        SetStick(num++, (sp + (p * (t * (299 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 300))) * vel);
        SetStick(num++, (sp + (p * (t * (301 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 302))) * vel);
        SetStick(num++, (sp + (p * (t * (303 + g)))) * vel);
        SetStick(num++, (sp + (p * (t * (304 + g)))) * vel);
        SetStick(num++, (sp + (p * (t * (305 + g)))) * vel);
        SetStick(num++, (sp + (p * (t * (306 + g)))) * vel);
        SetStick(num++, (sp + (p * (t * (307 + g)))) * vel);
       
        //SetStick(num++, (sp + (p * (t (* 308))) * vel);
        SetStick(num++, (sp + (p * (t * (309 + g)))) * vel);
        //SetStick(num++, (sp + (p * (t (* 310))) * vel);
        SetStick(num++, (sp + (p * (t * (311 + g)))) * vel);


        // --------------------------------------

        Max = num;
    }

    public override void SetEnemyData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = -5.0f;
        float bpm = 150.0f;
        float sp = 0.10f;
        float p = 30 / bpm;
        float t = 1.0f;
        float g = -1.5f;
        //185から201連打
        //237  243
        //253  261
        //290から307
        // Enemyコピペゾーン --------------------
        SetEnemy(num++, (sp + (p * (t * (9 + g)))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (17 + g)))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (25 + g)))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (33 + g)))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (35 + g)))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (39 + g)))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (41 + g)))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (45 + g)))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (47 + g)))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (49 + g)))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (57 + g)))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (65 + g)))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (69 + g)))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (75 + g)))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (77 + g)))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (79 + g)))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (89 + g)))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (99 + g)))) * vel - error, 1 * updown, enemyTypeA);
        
        SetEnemy(num++, (sp + (p * (t * (103 + g)))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (105 + g)))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (109 + g)))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (115 + g)))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (117 + g)))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (105 + g)))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (123 + g)))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (125 + g)))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (127 + g)))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (137 + g)))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (149 + g)))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (153 + g)))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (157 + g)))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (159 + g)))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (161 + g)))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (167 + g)))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (170 + g)))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (179 + g)))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (181 + g)))) * vel - error, 0 * updown, enemyTypeA);
       
        SetEnemy(num++, (sp + (p * (t * (205 + g)))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (207 + g)))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (209 + g)))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (215 + g)))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (217 + g)))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (219 + g)))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (223 + g)))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (233 + g)))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (235 + g)))) * vel - error, 0 * updown, enemyTypeA);
       
        
        SetEnemy(num++, (sp + (p * (t * (263 + g)))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (267 + g)))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (269 + g)))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (271 + g)))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (279 + g)))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * (281 + g)))) * vel - error, 1 * updown, enemyTypeA);
      
        // --------------------------------------
    }

    public override void SetObstacleData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float bpm = 150.0f;
        float sp = 0.10f;
        float p = 30 / bpm;
        float t = 1.0f;
        float error = -5.0f;
        float g = -1.5f;

        //185から201
        //237  243
        //253  261

        //290から307
        // Obstacleコピペゾーン -----------------
        SetObstacle(num++, (sp + (p * (t * (13 + g)))) * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (21 + g)))) * vel - error,0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (29 + g)))) * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (31 + g)))) * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (37 + g)))) * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (43 + g)))) * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (53 + g)))) * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (61 + g)))) * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (71 + g)))) * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (73 + g)))) * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (81 + g)))) * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (87 + g)))) * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (93 + g)))) * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (107 + g)))) * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (111 + g)))) * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (119 + g)))) * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (129 + g)))) * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (131 + g)))) * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (133 + g)))) * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (143 + g)))) * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (155 + g)))) * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (163 + g)))) * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (165 + g)))) * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (168 + g)))) * vel - error,0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (172 + g)))) * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (174 + g)))) * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (176 + g)))) * vel - error, 1 * updown, obstacleTypeA);
       
        SetObstacle(num++, (sp + (p * (t * (203 + g)))) * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (211 + g)))) * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (213 + g)))) * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (221 + g)))) * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (225 + g)))) * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (229 + g)))) * vel - error, -1 * updown, obstacleTypeA);       
        SetObstacle(num++, (sp + (p * (t * (265 + g)))) * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (273 + g)))) * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (277 + g)))) * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (285 + g)))) * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * (289 + g)))) * vel - error, 1 * updown, obstacleTypeA);
       
        // --------------------------------------
    }

    public override float SetMoveLimit()
    {
        // return ((stickPosDataArray[Max - 1]) + 6.0f);
        return ((stickPosDataArray[Max - 1]) + 6.0f);
    }

    public override int GetLastStick()
    {
        return (Max - 1);
    }
}
