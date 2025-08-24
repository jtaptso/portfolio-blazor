// Smooth scrolling for navigation links
document.querySelectorAll('.nav-link').forEach(function (link) {
    var href = link.getAttribute('href');
    // Only attach handler for anchor links
    if (href && href.startsWith('#')) {
        link.addEventListener('click', function (e) {
            e.preventDefault();
            const targetId = href.substring(1);
            const targetSection = document.getElementById(targetId);
            if (targetSection) {
                targetSection.scrollIntoView({ behavior: 'smooth', block: 'start' });
            }
            // Update active link: only this link
            document.querySelectorAll('.nav-link').forEach(function (l) { l.classList.remove('active'); });
            link.classList.add('active');
        });
    }
});

// Smooth scroll to an element by id (global)
window.scrollToSection = function (sectionId) {
    console.log('scrollToSection called with:', sectionId);
    var element = document.getElementById(sectionId);
    if (element) {
        element.scrollIntoView({ behavior: 'smooth' });
    } else {
        console.warn('Element not found for id:', sectionId);
    }
};

// Animate progress bars when in view
function animateProgressBars() {
    const progressBars = document.querySelectorAll('.progress-fill');
    progressBars.forEach(bar => {
        bar.classList.add('animated');
    });
}

// Update active nav link based on scroll position
function updateActiveNavLink() {
    const sections = document.querySelectorAll('section');
    const navLinks = document.querySelectorAll('.nav-link');

    let currentSection = '';

    sections.forEach(section => {
        const rect = section.getBoundingClientRect();
        if (rect.top <= 100 && rect.bottom >= 100) {
            currentSection = section.getAttribute('id');
        }
    });

    // Only activate the first matching nav-link for the current section
    navLinks.forEach(link => link.classList.remove('active'));
    const activeLink = Array.from(navLinks).find(link => link.getAttribute('href') === '#' + currentSection);
    if (activeLink) {
        activeLink.classList.add('active');
    }
}

// Handle form submission
const contactForm = document.querySelector('.contact-form');
if (contactForm) {
    contactForm.addEventListener('submit', function (e) {
        e.preventDefault();

        // Get form data
        const formData = new FormData(this);
        const name = formData.get('name');
        const email = formData.get('email');
        const subject = formData.get('subject');
        const message = formData.get('message');

        // Simple validation
        if (!name || !email || !subject || !message) {
            alert('Please fill in all fields.');
            return;
        }

        // Simulate form submission
        alert(`Thank you, ${name}! I'll get back to you soon.`);
        this.reset();
    });
}

// Event listeners
window.addEventListener('scroll', () => {
    animateProgressBars();
    updateActiveNavLink();
});

window.addEventListener('load', () => {
    animateProgressBars();
    updateActiveNavLink();
});

// Add some interactive hover effects
document.querySelectorAll('.skill-card, .project-card, .blog-card').forEach(card => {
    card.addEventListener('mouseenter', function () {
        this.style.transform = 'translateY(-10px)';
    });

    card.addEventListener('mouseleave', function () {
        this.style.transform = 'translateY(0)';
    });
});