


// $(function() {
//   $('.primary_menu > li').click(function() {
//     $(this).toggleClass(' showMe ');
//     $(this).siblings().removeClass(' showMe ');
//     $('.menu-overlay').stop().fadeOut();
//     $('.submenu').stop().slideUp();
//     $('.showMe .menu-overlay').stop().fadeIn();
//     $('.showMe .submenu').stop().slideDown();
//   });

// });



$(function(){
  
  $('.primary_menu > li > span').on('click',function(event){
    
    event.preventDefault();
    $(this).toggleClass('showMe');
    $(this).parent().find('.submenu').first().slideToggle();
    
    $(this).parent().siblings().find('.submenu').hide();
    
    //Hide menu when clicked outside
    $(this).parent().find('.submenu').parent().mouseleave(function(){ 
      var thisUI = $(this);
      $('html').click(function(){
        thisUI.children(".primary_menu > li").hide();
        thisUI.children("span").removeClass('showMe');
               
        $('html').unbind('click');
      });
    });
    
  });
  
});




$(document).on('click', function(event) {
  if (!$(event.target).closest('.sitenavigation').length) {
    // ... clicked on the 'body', but not inside of #menutop
    $('.submenu').slideUp();
    $(".primary_menu > li").siblings().removeClass(' showMe ');
  }
});



$(function() {

  $('.hamburger').click(function() {
    $(this).parent().toggleClass('is-tapped');
  });


  $('.toggle_footer_nav_link').click(function() {
    $('.footer_menu').toggleClass('active');
    $('.toggle_footer_nav_link i').toggleClass('fa-arrow-up');
  });

});







$(window).scroll(function() {
  var height = $(window).scrollTop();
  if (height > 50) {
    $(".scroll-container").addClass("hide");
  } else {
    $(".scroll-container").removeClass("hide");
  }
});


// document.querySelectorAll(".primary_menu > li a").forEach(link => {
//   link.addEventListener("click", e => {
//     if (link.classList.contains("active")) {
//       e.preventDefault(); // Stop navigation only if "active"
//     }
//   });
// });



////////////////////////////////////////////////////////////////////////Applications



var swiper = new Swiper('.home-slider > .swiper-container', {
  slidesPerView: 1,
  speed: 1200,
  spaceBetween: 0,
  slidesPerGroup: 1,
  draggable: true,
  loop: true,
  autoplay: true,
  effect: "fade",

  breakpoints: {
    768: {
      direction: "vertical",
    }
  },
  // loopFillGroupWithBlank: true,
  // navigation: {
  //   nextEl: '.home-slider .swiper-button-next',
  //   prevEl: '.home-slider .swiper-button-prev',
  // },
  pagination: {
    el: ".home-slider .swiper-pagination",
    clickable: true,
  // type: "fraction"
  },

});


var swiper = new Swiper('.work-areas-slider > .swiper-container', {
  slidesPerView: 5,
  spaceBetween: 24,
  slidesPerGroup: 1,
  loop: false,
  loopFillGroupWithBlank: true,
  breakpoints: {
    1200: {
      slidesPerView: 5,
      spaceBetween: 24,
    },
    768: {
      slidesPerView: 3,
      spaceBetween: 24,
    },
    576: {
      slidesPerView: 2,
      spaceBetween: 24,
    },
    300: {
      slidesPerView: 1.5,
      spaceBetween: 24,
    }
  },
  pagination: {
    el: '.swiper-pagination',
    clickable: true,
  },
  navigation: {
    nextEl: '.work-areas-slider .swiper-button-next',
    prevEl: '.work-areas-slider .swiper-button-prev',
  },
});




document.querySelectorAll('.three-col-slider').forEach((slider) => {
  const container = slider.querySelector('.swiper-container');
  const pagination = slider.querySelector('.swiper-pagination');
  const nextButton = slider.querySelector('.swiper-button-next');
  const prevButton = slider.querySelector('.swiper-button-prev');
  const navWrapper = nextButton.parentElement.parentElement; // adjust if needed

  const swiper = new Swiper(container, {
    slidesPerView: 3,
    spaceBetween: 24,
    slidesPerGroup: 1,
    loop: false,
    loopFillGroupWithBlank: true,
    breakpoints: {
      1024: {
        slidesPerView: 3,
        spaceBetween: 24,
      },
      768: {
        slidesPerView: 2.2,
        spaceBetween: 24,
      },
      600: {
        slidesPerView: 1.2,
        spaceBetween: 24,
      },
      300: {
        slidesPerView: 1.2,
        spaceBetween: 24,
      }
    },
    pagination: {
      el: pagination,
      clickable: true,
    },
    navigation: {
      nextEl: nextButton,
      prevEl: prevButton,
    },
    on: {
      init: () => toggleNavVisibility(),
      slideChange: () => toggleNavVisibility(),
      resize: () => toggleNavVisibility(),
    }
  });

  function toggleNavVisibility() {
    const prevDisabled = prevButton.classList.contains('swiper-button-disabled');
    const nextDisabled = nextButton.classList.contains('swiper-button-disabled');

    if (prevDisabled && nextDisabled) {
      navWrapper.classList.add('d-none');
    } else {
      navWrapper.classList.remove('d-none');
    }
  }
});




var swiper = new Swiper('.logo-slider > .swiper-container', {
  slidesPerView: 5,
  speed: 4000,
  spaceBetween: 0,
  slidesPerGroup: 1,
  draggable: false,
  loop: true,
  autoplay: {
    enabled: true,
    delay: 1,
  },
  autoplayTimeout: false,
  grabCursor: false,
  allowTouchMove: false,
  disableOnInteraction: true,
  // loopFillGroupWithBlank: true,
  // pagination: {
  // 	el: '.swiper-pagination',
  // 	clickable: true,
  // },
  navigation: false,
  breakpoints: {
    1200: {
      slidesPerView: 5,
    },
    991: {
      slidesPerView: 4,
    },
    600: {
      slidesPerView: 3,
    },
    360: {
      slidesPerView: 2,
    }
  },

});




/////////////////////////////////////////////////////////////////////////////Applications


if ($('body').hasClass('homepage')) {
  $(".homepage").addClass("active");
}
if ($('body').hasClass('aboutUs')) {
  $(".aboutUs").addClass("active");
}
if ($('body').hasClass('Career')) {
  $(".Career").addClass("active");
}
if ($('body').hasClass('ContactUs')) {
  $(".ContactUs").addClass("active");
}

if ($('body').hasClass('EducationAndSystems')) {
  $(".EducationAndSystems").addClass("active");
  $(".AreasOfWork").addClass("active");
}
if ($('body').hasClass('SchoolOfHealth')) {
  $(".SchoolOfHealth").addClass("active");
  $(".AreasOfWork").addClass("active");
}
if ($('body').hasClass('ClimateAndSustainability')) {
  $(".ClimateAndSustainability").addClass("active");
  $(".AreasOfWork").addClass("active");
}
if ($('body').hasClass('GenderAndInclusion')) {
  $(".GenderAndInclusion").addClass("active");
  $(".AreasOfWork").addClass("active");
}
if ($('body').hasClass('NurturingFutureLeaders')) {
  $(".NurturingFutureLeaders").addClass("active");
  $(".AreasOfWork").addClass("active");
}


if ($('body').hasClass('ResearchPapers')) {
  $(".ResearchPapers").addClass("active");
  $(".Publications").addClass("active");
}
if ($('body').hasClass('Reports')) {
  $(".Reports").addClass("active");
  $(".Publications").addClass("active");
}
if ($('body').hasClass('Articles')) {
  $(".Articles").addClass("active");
  $(".Publications").addClass("active");
}
if ($('body').hasClass('Blogs')) {
  $(".Blogs").addClass("active");
  $(".Publications").addClass("active");
}


if ($('body').hasClass('PressReleases')) {
  $(".PressReleases").addClass("active");
  $(".Latest").addClass("active");
}
if ($('body').hasClass('NewsStories')) {
  $(".NewsStories").addClass("active");
  $(".Latest").addClass("active");
}
if ($('body').hasClass('Videos')) {
  $(".Videos").addClass("active");
  $(".Latest").addClass("active");
}




/////////////////////////////////////////////////////////////////////////////Applications

$('input').on('focusin', function() {
  $(this).parent().find('label').addClass('active');
});
$('input').on('focusout', function() {
  if (!this.value) {
    $(this).parent().find('label').removeClass('active');
  }
});


$('textarea').on('focusin', function() {
  $(this).parent().find('label').addClass('active');
});
$('textarea').on('focusout', function() {
  if (!this.value) {
    $(this).parent().find('label').removeClass('active');
  }
});


$('select').on('focusin', function() {
  $(this).parent().find('label').addClass('active');
});
$('select').on('focusout', function() {
  if (!this.value) {
    $(this).parent().find('label').removeClass('active');
  }
});




//////////////////////////////////////Parallax Image Start/////////////////////////////////////




// window.onload = function() {
//   $('.parallax-left').simpleParallax({ overflow: true, orientation: 'left', });
//   $('.parallax-right').simpleParallax({ overflow: true, orientation: 'right', });
//   $('.parallax-left-overflow').simpleParallax({ orientation: 'left', scale: 1.2, overfow: true });
//   $('.parallax-up').simpleParallax({ delay: 0, orientation: 'top', scale: 1.25, overfow: true });
//   $('.parallax-down').simpleParallax({ delay: 0, orientation: 'down', scale: 1.25, overfow: true });
// }






//////////////////////////////////////Parallax Image End/////////////////////////////////////



// var a = 0;
// $(window).scroll(function() {
//   var counterBox = $(".counter-box");

//   if (counterBox.length > 0) { // Check if element exists
//     var oTop = counterBox.offset().top - window.innerHeight;

//     if (a == 0 && $(window).scrollTop() > oTop) {
//       $(".counter").each(function() {
//         var $this = $(this),
//           countTo = $this.attr("data-number");
//         $({
//           countNum: $this.text()
//         }).animate(
//           {
//             countNum: countTo
//           },
//           {
//             duration: 2000,
//             easing: "swing",
//             step: function() {
//               $this.text(
//                 Math.ceil(this.countNum).toLocaleString("en")
//               );
//             },
//             complete: function() {
//               $this.text(
//                 Math.ceil(this.countNum).toLocaleString("en")
//               );
//             }
//           }
//         );
//       });
//       a = 1;
//     }
//   }
// });

var counterStarted = false;

$(window).on("scroll", function() {
  var counterBox = $(".counter-box");

  if (counterBox.length > 0) {
    var oTop = counterBox.offset().top - window.innerHeight;

    if (!counterStarted && $(window).scrollTop() > oTop) {
      $(".counter").each(function() {
        var $this = $(this);
        var countTo = parseInt($this.attr("data-number"));

        $({
          countNum: 0
        }).animate(
          {
            countNum: countTo
          },
          {
            duration: 2000,
            easing: "swing",
            step: function(now) {
              $this.text(Math.ceil(now).toLocaleString("en"));
            },
            complete: function() {
              $this.text(countTo.toLocaleString("en"));
            },
          }
        );
      });

      counterStarted = true;
    }
  }
});






////////////////////////////////////////////////////////////////////





$(document).ready(function () {
  $('.hover-group').each(function () {
    var $group = $(this);
    var $boxes = $group.find('.work-area-details');
    var $links = $group.find('.nav_menu');

    // Determine the default box for the group
    var $activeLink = $links.filter('.active');
    var $defaultBox;

    if ($activeLink.length > 0) {
      $defaultBox = $group.find('#' + $activeLink.data('target'));
    } else {
      $defaultBox = $boxes.first();
    }

    // Initially show default, hide others
    $boxes.hide();
    $defaultBox.show();

    // On hover in: show hovered box
    $links.on('mouseenter', function () {
      var targetId = $(this).data('target');
      $boxes.hide();
      $group.find('#' + targetId).show();
    });

    // On hover out: show default again
    //$links.on('mouseleave', function () {
    //  $boxes.hide();
    //  $defaultBox.show();
    //});
  });
});



////////////////////////////////////////////////////////////////////



$(document).ready(function() {
  $(".horizontal-tab .nav-link").click(function() {
    var position = $(this).position();
    var width = $(this).parent().width();
    if (position) {
      $(".horizontal-tab .nav-tabs .tab-slider").css({"left": position.left, "width": width});
    }
  });

  var activeNavLink = $(".horizontal-tab .nav-item .nav-link.active");
  if (activeNavLink.length) {
    var actWidth = activeNavLink.parent("li").width();
    var actPosition = activeNavLink.position();
    if (actPosition) {
      $(".horizontal-tab .nav-tabs .tab-slider").css({"left": actPosition.left, "width": actWidth});
    }
  }
});



////////////////////////////////////////////////////////////////////


$(function() {
  'use strict';
  $(activate);
  function activate() {
    $('.horizontal-tab .nav-tabs')
      .scrollingTabs({
				cssClassLeftArrow: 'fa fa-chevron-left',
    		cssClassRightArrow: 'fa fa-chevron-right',
				disableScrollArrowsOnFullyScrolled: true,
			})
  }
}());




////////////////////////////////////////////////////////////////////



if (window.matchMedia('(min-width: 991px)').matches) {
    
  $('button[data-bs-toggle="tab"]').on('shown.bs.tab', function () {
    $('.parent-div').each(function () {
      var first = $(this).find('.rs-text-box');
      var second = $(this).find('.ls-img-rounded');
      
      var height = first.outerHeight();
      second.height(height);
    });
  });

  $('.parent-div').each(function () {
      var first = $(this).find('.rs-text-box');
      var second = $(this).find('.ls-img-rounded');
      
      var height = first.outerHeight();
      second.height(height);
    });

}



////////////////////////////////////////////////////////////////////




  document.querySelectorAll('.slider').forEach((slider) => {
    const slides = slider.querySelectorAll('.slide');
    let current = 0;

    function showSlide(index) {
      slides.forEach((slide) => {
        slide.classList.remove('active', 'activenext');
      });

      slides[index].classList.add('active');
      const nextIndex = (index + 1) % slides.length;
      slides[nextIndex].classList.add('activenext');
    }

    setInterval(() => {
      current = (current + 1) % slides.length;
      showSlide(current);
    }, 3000); // Every 3 seconds
  });


////////////////////////////////////////////////////////////////////








$(".people-card").on("click", function() {
  const personKey = $(this).data("person");
  const person = peopleData[personKey];

  if (person) {
    $("#LeaderImage").attr("src", person.image);
    $("#LeaderName").text(person.name);
    $("#LeaderLink").html(person.link);
    $("#LeaderDescription").html(person.description);
  }
});

var peopleData = {
  AnshuDubey: {
    image: "assets/images/people/anshu-duby.webp",
    name: "Anshu Dubey",
    link: `<a target="_blank" href="https://www.linkedin.com/in/monal-jayaram-5a391116?miniProfileUrn=urn%3Ali%3Afs_miniProfile%3AACoAAANWpwsBBI7a4Tn9dvQgcnJCjwKbf4skM6I&lipi=urn%3Ali%3Apage%3Ad_flagship3_search_srp_all%3BD8FYKetpRKmHJUu%2BRaCTPw%3D%3D" class="fs-4 text-white" aria-label="Follow us on Linkedin"><i class="fa-brands fa-linkedin"></i></a>`,
    description: `<p>A psychologist with more than 2 decades of experience, Anshu specializes in Social Emotional Learning, Life Skills, Behavioural Assessments, Compassion Training and Organizational Development. She has been driving systemic integration of Social, Emotional and Ethical (SEE) Learning and large-scale culture transformation projects focussed on building compassionate systems. She has been actively involved in various national and state-level resource groups, including the School Health and Wellness Program Curriculum developed by NCERT under the Ayushman Bharat initiative, NIEPA and SCERTs. Anshu is also leading strategic national and international partnerships to facilitate organisational and program imperatives.</p>`
  },
  DeepakMajeethia: {
    image: "assets/images/people/deepak-majeethia.webp",
    name: "Deepak Majeethia",
    link: ``,
    description: `<p>Deepak Majeethia is the co-lead of School of Gender and Inclusion. One of its big focus areas is driving economic and social empowerment of rural women through systems change by working jointly with government, communities and eco-system partners. Deepak is passionate about inclusion of men and boys in driving the agenda of gender equality.</p>
    <p>He has earlier worked for over three decades in the corporate world including 22 years at Genpact leading large global businesses, with experience in digital transformation, strategy, excellence in execution, and scaling organizations.</p>`
  },
  GhanshyamSoni: {
    image: "assets/images/people/ghanshyam-soni.webp",
    name: "Ghanshyam Soni",
    link: `<a target="_blank" href="https://www.linkedin.com/in/ghanshyam-soni-03221a47/" class="fs-4 text-white" aria-label="Follow us on Linkedin"><i class="fa-brands fa-linkedin"></i></a>`,
    description: `<p>Ghanshyam Soni is a pivotal member of the Core Team at the School of Education and Systems Change, Piramal School of Leadership. With 18 years of distinguished experience, he excels in education, leadership development, strategy, innovation, specialized partnership management, and policy advocacy. A lawyer by profession, Ghanshyam is a visionary strategist and transformative leader, driving systemic, high-impact 21st-century education reforms on a grand scale. </p>`
  },
  KartikVarma: {
    image: "assets/images/people/kartik-varma.webp",
    name: "Kartik Varma",
    link: `<a target="_blank" href="https://www.linkedin.com/in/kartikvarma?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_medium=android_app" class="fs-4 text-white" aria-label="Follow us on Linkedin"><i class="fa-brands fa-linkedin"></i></a>`,
    description: ` <p>Kartik serves as part of the leadership team at the Piramal Foundation, and leads the Piramal School of Leadership's School of Health. He brings 25 years of global experience in government reform, talent and culture transformation across industries. He has lived and worked across India, South East Asia and the MENA region, in leadership roles across corporate and philanthropy. He graduated from INSEAD Singapore.</p>`
  },
  MonalJayaram: {
    image: "assets/images/people/monal-jayaram.webp",
    name: "Monal Jayaram",
    link: ``,
    description: `<p>Monal Jayaram is the Co-Founder and Director of the School of Education and Systems Change, Piramal School of Leadership. Monal pioneered educational change initiatives on 21st century competencies & Social Emotional Ethical Learning, Project Based Learning and Assessment Reform. She also leads large-scale girls education projects and global initiatives and collaborates with institutions like Harvard, Emory and NYU.</p>`
  },
  NeelimaPandey: {
    image: "assets/images/people/neelima-pandey.webp",
    name: "Dr. Neelima Pandey",
    link: ``,
    description: `<p>Dr. Neelima is the Co-Founder and Director at the School of Inclusion, Piramal School of Leadership, bringing nearly 25 years of experience advancing the rights and inclusion of women and children. She has led large-scale programs with global organizations like Plan International, driving sustainable impact and systemic change at scale. A Clinical Psychologist by training, Dr. Neelima brings a deep commitment to equity-driven, evidence-based approaches in mental health and inclusive development policy. She also spearheads the Karuna Fellowship, a transformative platform that enables women to embark on journeys of self-discovery and emerge as compassionate changemakers in their communities and beyond.</p>`
  },
  SangeetaMamgain: {
    image: "assets/images/people/sangeeta-mamgain.webp",
    name: "Sangeeta Mamgain",
    link: ``,
    description: ` <p>Sangeeta Mamgain is the Founder of the School of Climate and Sustainability at the Piramal School of Leadership. With 18 years as a web solutions entrepreneur, she transitioned to the Piramal Foundation, where she leads the School of Climate and Sustainability across four states and two ministries. She focuses on embedding a systems change approach into sustainability through governance reforms, capacity-building, and delivering impactful, scalable solutions for climate resilience.</p>`
  },
  SaurabhJohri: {
    image: "assets/images/people/saurabh-johri.webp",
    name: "Saurabh Johri",
    link: ``,
    description: ` <p>Saurabh Johri is the Co-founder and Director of the School of Education and Systems Change, Piramal School of Leadership. His current work is centred around working with the last mile public delivery officials, middle managers in government, and communities, learning with them and supporting policy makers in transitioning towards a Viksit Bharat.</p><p>Saurabh has previously worked with World Bank, Asian Development Bank, McKinsey and PwC advising on public systems reforms. He has also worked with non-profits like Pratham, Azim Premji Foundation, and Observer Research Foundation. He is a postgraduate in public policy from IIM Ahmedabad and pursuing PhD at TISS, Mumbai, researching on issues of public policy.</p>`
  },
  SridharSrikantiah: {
    image: "assets/images/people/sridhar-srikantiah.webp",
    name: "Dr. Sridhar Srikantiah",
    link: ``,
    description: `<p>Dr. Sridhar Srikantiah, Senior Health Advisor in the School of Health at Piramal Foundation, is an MD and a trained Pediatrician and Public Health practitioner with over 30 years of experience. He served as the Technical Lead for CARE India and has advised the BMGF health initiatives in Bihar since 2010. He has also supported World Bank projects focused on vector-borne disease control and reforms in the Integrated Child Development Services (ICDS) across India. At Piramal Foundation, he designs large-scale maternal and child health, nutrition, and communicable disease programs aimed at improving national health indicators.</p>`
  },
  SunilBabu: {
    image: "assets/images/people/sunil-babu.webp",
    name: "Dr. Sunil Babu",
    link: ``,
    description: ` <p>Dr. Sunil Babu is Co lead School of Health at Piramal School of Leadership. He previously served as Executive Director- Health and Nutrition and Chief of Party-BTSP, CARE India. He is a medical graduate with management education. He has worked through the ranks within CARE starting as a Field Officer in Andhra Pradesh in 1999 . He has gained public health program management experience in multiple states and national level and has worked as a consultant with several organizations including the Bill & Melinda Gates Foundation and the World Bank.</p>`
  },
  VaibhavPandey: {
    image: "assets/images/people/vaibhav-pandey.webp",
    name: "Vaibhav Pandey",
    link: ``,
    description: `<p>Vaibhav, a Core team member at Piramal School of Leadership, drives initiatives in leadership development and organizational change while working deeply with government education systems nationwide. He has collaborated with states like Delhi, Andhra Pradesh, Maharashtra, Rajasthan, Bihar, and Jharkhand, as well as institutions and think tanks such as the Capacity Building Commission, MITRA, and MoSJE. An alumnus of Hindu College and Xavier Institute of Management, and part of the first batch of the Gandhi Fellowship Program, Vaibhav is committed to fostering personal transformation as a foundation for societal change and empowering communities to create a more equitable society.</p><p>Prior to rejoining the Piramal Foundation in 2014, Vaibhav worked in Marketing and Below the Line activations where he helpoed Glaxo Smith Kline , Perfetti , Eicher Motors in tapping markets at bottom of the pyramid . </p>`
  },

}

