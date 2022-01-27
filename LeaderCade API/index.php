<?php

// CONNECTION
$servername = "sql5.freesqldatabase.com";
$username = "sql5468043";
$password = "ZaIh95EqUV";
$db = "sql5468043";
$conn = new mysqli($servername, $username, $password, $db);
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// CREATE USER
if(isset($_POST['new_user'])) {
    $query = $conn->prepare("INSERT INTO user (nickname) VALUES (?);");
    $query->bind_param("s", $_POST["new_user"]);
    $query->execute();
}

// READ USER
if(isset($_POST['get_user'])) {
    $query = "SELECT * FROM user WHERE nickname = '" . $_POST['get_user'] . "'";
    $result = mysqli_query($conn, $query);
    $Rows = array();
    while ($row = mysqli_fetch_array($result)) {
        $Rows[] = $row;
    }
    if(count($Rows) != 0){
        echo $Rows[0]["id"]."|".$Rows[0]["nickname"]."|".$Rows[0]["highscore"]."|".$Rows[0]["totalscore"]."|".$Rows[0]["team_id"];
    }
}

// UPDATE USER HIGH
if(isset($_POST['new_highscore'])) {
    $query = $conn->prepare("UPDATE user SET `highscore`=? WHERE `id`=?");
    $query->bind_param("ss", $_POST["new_highscore"], $_POST["user_id"]);
    $query->execute();
}

// UPDATE USER TOTAL
if(isset($_POST['new_totalscore'])) {
    $query = $conn->prepare("UPDATE user SET `totalscore`=? WHERE `id`=?");
    $query->bind_param("ss", $_POST["new_totalscore"], $_POST["user_id"]);
    $query->execute();
}

// UPDATE USER TEAM
if(isset($_POST['new_teamid'])) {
    $query = $conn->prepare("UPDATE user SET `team_id`=? WHERE `id`=?");
    $query->bind_param("ss", $_POST["new_teamid"], $_POST["user_id"]);
    $query->execute();
}

// CREATE TEAM
if(isset($_POST['new_team'])) {
    $query = $conn->prepare("INSERT INTO team (name) VALUES (?);");
    $query->bind_param("s", $_POST["new_team"]);
    $query->execute();
}

// READ TEAM
if(isset($_POST['get_team'])) {
    $query = "SELECT * FROM team WHERE id = '" . $_POST['get_team'] . "'";
    $result = mysqli_query($conn, $query);
    $Rows = array();
    while ($row = mysqli_fetch_array($result)) {
        $Rows[] = $row;
    }
    if(count($Rows) != 0){
        echo $Rows[0]["id"]."|".$Rows[0]["name"];
    }
}

// READ TEAM USER COUNT
if(isset($_POST['get_team_usercount'])) {
    $query = "SELECT COUNT(user.id) as count FROM user INNER JOIN team t on user.team_id = t.id WHERE team_id = '" . $_POST['get_team_usercount'] . "'";
    $result = mysqli_query($conn, $query);
    $Rows = array();
    while ($row = mysqli_fetch_array($result)) {
        $Rows[] = $row;
    }
    if(count($Rows) != 0){
        echo $Rows[0]["count"];
    }
}

// READ TEAM LEADER
if(isset($_POST['get_team_leader'])) {
    $query = "SELECT nickname FROM team INNER JOIN user u on team.id = u.team_id WHERE team_id = '" . $_POST['get_team_leader'] . "' ORDER BY highscore DESC LIMIT 1";
    $result = mysqli_query($conn, $query);
    $Rows = array();
    while ($row = mysqli_fetch_array($result)) {
        $Rows[] = $row;
    }
    if(count($Rows) != 0){
        echo $Rows[0]["nickname"];
    }
}

// UPDATE TEAM NAME
if(isset($_POST['new_team_name'])) {
    $query = $conn->prepare("UPDATE team SET `name`=? WHERE `id` = ?");
    $query->bind_param("ss", $_POST["new_team_name"], $_POST["team_id"]);
    $query->execute();
}

// DELETE TEAM
if(isset($_POST['delete_team'])) {
    $query = $conn->prepare("DELETE FROM team where `id` = ?");
    $query->bind_param("s", $_POST["delete_team"]);
    $query->execute();
}

// FRIENDS HIGH LEADERBOARD
if(isset($_POST['get_friends_high'])) {
    $query = "SELECT nickname, highscore from user WHERE team_id = '" . $_POST['get_friends_high'] . "' ORDER BY highscore DESC";
    $result = mysqli_query($conn, $query);
    $Rows = array();
    while ($row = mysqli_fetch_array($result)) {
        $Rows[] = $row;
    }
    foreach ($Rows as $row){
        echo $row["nickname"].",".$row["highscore"]."|";
    }
}

// FRIENDS TOTAL LEADERBOARD
if(isset($_POST['get_friends_total'])) {
    $query = "SELECT nickname, totalscore from user WHERE team_id = '" . $_POST['get_friends_total'] . "' ORDER BY totalscore DESC";
    $result = mysqli_query($conn, $query);
    $Rows = array();
    while ($row = mysqli_fetch_array($result)) {
        $Rows[] = $row;
    }
    foreach ($Rows as $row){
        echo $row["nickname"].",".$row["totalscore"]."|";
    }
}

// TEAMS HIGH LEADERBOARD
if(isset($_POST['get_teams_high'])) {
    $query = "SELECT name, sum(highscore) as highscore FROM team INNER JOIN user u on team.id = u.team_id GROUP BY name ORDER BY highscore DESC;";
    $result = mysqli_query($conn, $query);
    $Rows = array();
    while ($row = mysqli_fetch_array($result)) {
        $Rows[] = $row;
    }
    foreach ($Rows as $row){
        echo $row["name"].",".$row["highscore"]."|";
    }
}

// TEAMS TOTAL LEADERBOARD
if(isset($_POST['get_teams_total'])) {
    $query = "SELECT name, sum(totalscore) as totalscore FROM team INNER JOIN user u on team.id = u.team_id GROUP BY name ORDER BY totalscore DESC;";
    $result = mysqli_query($conn, $query);
    $Rows = array();
    while ($row = mysqli_fetch_array($result)) {
        $Rows[] = $row;
    }
    foreach ($Rows as $row){
        echo $row["name"].",".$row["totalscore"]."|";
    }
}

mysqli_close($conn);