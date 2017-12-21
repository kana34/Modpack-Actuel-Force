<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Information mods</title>
</head>

<body>
<?php
$dir = $_GET['nom'].'/';
if ( is_dir($dir) )  {
	if ( $dh = opendir($dir) ) {
		while ( ($element = readdir($dh)) !== false){{
				if (	($element != '_vti_cnf')	&
					($element != '.')		&
					($element != '..')		&
					($element != '.DS_Store')	){
						
						if (is_dir($dir.'/'.$element))
						{
							$tb_directories[] = $element;	
						}
						else
						{
							$tb_files[] = $element;	
						}
					}
				}	
			}
		}
	}

foreach($tb_directories AS $value) echo '<img src="'. $dir . $value .'" style="max-height:200px;" />' . '<br>';
foreach($tb_files AS $value) echo '<img src="'. $dir . $value .'" style="max-height:200px;" />' . '<br>';

?>
</body>
</html>