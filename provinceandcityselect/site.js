var provinceandcities = {};
provinceandcities['Classroom Instruction and Assessment'] = ['Assessment Day', 'Common Assessment Development', 'Data Team', 'Kindergarten Screening', 'Other'];
provinceandcities['Curriculum Development and Alignment'] = ['Capstone Development', 'Course Of Study Development / Revision', 'Standards Alignment / Rollout', 'Other'];
provinceandcities['District Committee'] = ['Curriculum Council', 'Grading & Assessment Task Force', 'Professional Development Planning Committee', 'Race To The Top Committee', 'Teacher Evaluation Committee', 'Other'];
provinceandcities['Meeting'] = ['Academic Support Team', 'ELL / eKLIP Teachers', 'Gifted Intervention Specialist', 'Intervention Assistance Team', 'Intervention Teachers', 'Kindergarten Parent Conference', 'KLIP Teachers', 'Title I Teachers', 'Other'];
provinceandcities['Other Category'] = ['Other'];
provinceandcities['Professional Conference'] = ['Conference'];
provinceandcities['Professional Workshop / Training'] = ['In-District', 'Out-Of-District'];
provinceandcities['Pupil Services'] = ['IEP Meeting', 'IEP Writing'];

function Changeprovincelist() {
    var provincelist = document.getElementById("validationCustom03");
    var citylist = document.getElementById("validationCustom04");
    var selprovince = provincelist.options[provincelist.selectedIndex].value;
    while (citylist.options.length) {
        citylist.remove(0);
    }
    var provinces = provinceandcities[selprovince];
    if (provinces) {
        var i;
        for (i = 0; i < provinces.length; i++) {
            var cat = new Option(provinces[i], i);
            citylist.options.add(cat);
        }
    }
} 
