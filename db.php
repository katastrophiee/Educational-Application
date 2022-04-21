<?php
	$q = $_REQUEST["q"];
	$conn = new mysqli("localhost", "root", "", "directors_cut");
	$sql = "INSERT INTO bull (score)
	VALUES ('$q') WHERE score = NULL";
	mysqli_query($conn,$sql);
?>