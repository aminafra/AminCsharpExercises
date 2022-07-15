-----------------------------(1)-------------------------------------------
SELECT SC.country_name,SC.country_abbr FROM dbo.match_details MD
INNER JOIN dbo.[Soccer Country] SC
ON sc.country_id = MD.team_id
WHERE MD.match_no = 1
-----------------------------(2)-------------------------------------------
SELECT MD.team_id,SC.country_abbr,SC.country_name FROM dbo.match_details MD
INNER JOIN dbo.[Soccer Country] SC
ON SC.country_id = MD.team_id
WHERE MD.play_stage=N'F' AND MD.win_lose=N'W'
-----------------------------(3)-------------------------------------------
SELECT SC.country_name,SC.country_abbr FROM dbo.match_mast MM
INNER JOIN dbo.match_details MD
ON MD.match_no = MM.match_no
INNER JOIN dbo.[Soccer Country] SC
ON SC.country_id = MD.team_id
WHERE MM.audence = (SELECT MAX(audence) FROM dbo.match_mast)
-----------------------------(4)-------------------------------------------
SELECT SC.country_name,MM.results FROM dbo.match_details MD
INNER JOIN dbo.match_mast MM
ON MM.match_no = MD.match_no
INNER JOIN dbo.[Soccer Country] SC
ON MD.team_id = SC.country_id
WHERE MD.match_no = 34
-----------------------------(5)-------------------------------------------
SELECT SC.country_name,SC.country_abbr FROM dbo.match_details MD
INNER JOIN dbo.[Soccer Country] SC
ON sc.country_id = MD.team_id
WHERE MD.match_no = (SELECT MAX(match_no) FROM dbo.match_details) AND MD.win_lose = N'L'
-----------------------------(6)-------------------------------------------
SELECT MD.match_no,SC.country_name,MD.goal_score FROM dbo.match_details MD
INNER JOIN dbo.[Soccer Country] SC
ON MD.team_id = SC.country_id
WHERE MD.decided_by = N'N'
-----------------------------(7)-------------------------------------------
SELECT TOP 1 SCO.country_name FROM dbo.soccer_venue SV
INNER JOIN dbo.Soccer_city SC
ON SC.city_id = SV.city_id
INNER JOIN dbo.[Soccer Country] SCO
ON SCO.country_id = SC.country_id