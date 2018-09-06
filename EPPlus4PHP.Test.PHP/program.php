<?php

use nulastudio\Document\EPPlus4PHP\ExcelPackage;
use nulastudio\Document\EPPlus4PHP\ExcelConvert;
use nulastudio\Document\EPPlus4PHP\Range;

// $package = new ExcelPackage(__DIR__ . '/test.xlsx');


// worksheet
// var_dump(isset($package->workBook->workSheets[1]));
// var_dump(isset($package->workBook->workSheets[2]));
// var_dump(isset($package->workBook->workSheets[3]));
// var_dump(isset($package->workBook->workSheets['test sheet']));
// var_dump(isset($package->workBook->workSheets['test sheet2']));
// var_dump($package->workBook->workSheets['test sheet2']->cells['A1']);

// $package->workBook->workSheets->add('test sheet');

// addressing
// var_dump(ExcelConvert::toName(100));
// var_dump(ExcelConvert::toName(9999));
// var_dump(ExcelConvert::toName(1048576));
// var_dump(ExcelConvert::toIndex('A'));
// var_dump(ExcelConvert::toIndex('XFD'));
// $tmp_addr;
// var_dump(Range::tryParseAddress("a", $tmp_addr), $tmp_addr);
// var_dump(Range::tryParseAddress("a", $tmp_addr), $tmp_addr); // y
// var_dump(Range::tryParseAddress("xfd", $tmp_addr), $tmp_addr); // y
// var_dump(Range::tryParseAddress("xfe", $tmp_addr), $tmp_addr); // n
// var_dump(Range::tryParseAddress("0", $tmp_addr), $tmp_addr);   // n
// var_dump(Range::tryParseAddress("1", $tmp_addr), $tmp_addr);   // y
// var_dump(Range::tryParseAddress("88888888", $tmp_addr), $tmp_addr);   // n
// var_dump(Range::tryParseAddress("a:a", $tmp_addr), $tmp_addr); // y
// var_dump(Range::tryParseAddress("1:1", $tmp_addr), $tmp_addr); // y
// var_dump(Range::tryParseAddress("da", $tmp_addr), $tmp_addr);  // y
// var_dump(Range::tryParseAddress("a,1,1:1,a2,a2:a5", $tmp_addr), $tmp_addr); // y
// var_dump(Range::tryParseAddress("a,1,1:1,a2,88888888,1q:q1,a2:a5", $tmp_addr), $tmp_addr); // n

// $package->save();

// var_dump($package);

// ArrayAccess
// var_dump($package->workBook->workSheets[1]);
// var_dump($package->workBook->workSheets[2]);
// var_dump($package->workBook->workSheets['test sheet']);
// var_dump($package->workBook->workSheets['test sheet2']);

// Countable
// var_dump(count($package->workBook->workSheets));

// IEnumerable
// foreach ($package->workBook->workSheets as $name => $worksheet) {
//     var_dump($name/* , $worksheet */);
// }
// foreach ($package->workBook->workSheets as $name => $worksheet) {
//     var_dump($name/* , $worksheet */);
// }

// addressing and cells

// $range = $package->workBook->workSheets['test sheet']->cells['A1']->style->font->size = 50;

// var_dump($range);

// $package->workBook->workSheets['test sheet']->cells['A1']->font->size = 50;


// $package->save();