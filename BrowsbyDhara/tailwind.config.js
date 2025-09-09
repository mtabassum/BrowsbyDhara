/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        // Pages folder - all Razor components
        "./Pages/**/*.{razor,html,cshtml}",

        // Components folder and subfolders
        "./Components/**/*.{razor,html,cshtml}",
        "./Components/Layout/**/*.{razor,html,cshtml}",

        // Other Razor files in root
        "./*.{razor,html,cshtml}",
        "./App.razor",
        "./Routes.razor",
        "./_Imports.razor",

        // wwwroot static files
        "./wwwroot/**/*.{html,js}",
        "./wwwroot/js/**/*.js",

        // Styles folder (if you have any HTML templates there)
        "./Styles/**/*.{html,css}",

        // Any other potential locations for content
        "./Views/**/*.{razor,html,cshtml}",
        "./Shared/**/*.{razor,html,cshtml}"
    ],
    theme: {
        extend: {
            colors: {
                'primary-3': {
                    '50': '#f5eff1',
                    '100': '#f7b4c9',
                    '200': '#f280a4',
                    '300': '#ec4c7f',
                    '400': '#e7185a',
                    '500': '#b31346',
                    '600': '#7f0d31',
                    '700': '#4b081d',
                    '800': '#170209',
                },
                // Your custom spa color palette
                'spa-pink': {
                    50: '#fdf2f8',
                    100: '#fce7f3',
                    200: '#fbcfe8',
                    300: '#f9a8d4',
                    400: '#f472b6',
                    500: '#ec4899',
                    600: '#db2777',
                    700: '#be185d',
                    800: '#9d174d',
                    900: '#831843',
                },
                'spa-rose': {
                    400: '#fb7185',
                    500: '#f43f5e',
                    600: '#e11d48',
                },
                // Alternative color schemes you can try:

                // Purple theme
                'spa-purple': {
                    50: '#faf5ff',
                    100: '#f3e8ff',
                    200: '#e9d5ff',
                    300: '#d8b4fe',
                    400: '#c084fc',
                    500: '#a855f7',
                    600: '#9333ea',
                    700: '#7c3aed',
                    800: '#6b21a8',
                    900: '#581c87',
                },

                // Blue theme
                'spa-blue': {
                    50: '#eff6ff',
                    100: '#dbeafe',
                    200: '#bfdbfe',
                    300: '#93c5fd',
                    400: '#60a5fa',
                    500: '#3b82f6',
                    600: '#2563eb',
                    700: '#1d4ed8',
                    800: '#1e40af',
                    900: '#1e3a8a',
                },

                // Green theme
                'spa-green': {
                    50: '#ecfdf5',
                    100: '#d1fae5',
                    200: '#a7f3d0',
                    300: '#6ee7b7',
                    400: '#34d399',
                    500: '#10b981',
                    600: '#059669',
                    700: '#047857',
                    800: '#065f46',
                    900: '#064e3b',
                },

                // Custom brand colors (example)
                'brand': {
                    'primary': '#ec4899',
                    'secondary': '#f43f5e',
                    'accent': '#fb7185',
                    'neutral': '#6b7280',
                    'dark': '#374151',
                }
            },

            // Custom gradients
            backgroundImage: {
                'spa-gradient': 'linear-gradient(135deg, #fce7f3 0%, #fbcfe8 50%, #f9a8d4 100%)',
                'hero-gradient': 'linear-gradient(135deg, #ec4899 0%, #f43f5e 100%)',
            },

            // Custom font family (optional)
            fontFamily: {
                'spa': ['Poppins', 'Inter', 'sans-serif'],
            },

            // Custom spacing (optional)
            spacing: {
                '18': '4.5rem',
                '88': '22rem',
            }
        },
    },
    plugins: [],
}