import { Bell } from "lucide-react";
import React from "react";
import logo from "./logo.png";

interface Props {}

const Navbar = (props: Props) => {
    return (
        <header className="fixed top-0 left-0 right-0 h-16 bg-background border-b border-border z-50">
            <div className="flex items-center justify-between h-full px-6">
                {/* Logo */}
                <a href="/" className="flex items-center gap-2">
                    <img src={logo} alt="Logo" className="w-12 h-12" />
                </a>

                {/* Right Side Navigation */}
                <div className="flex items-center gap-4">
                    {/* <div className="relative">
                        <button className="relative flex items-center justify-center w-10 h-10 rounded-md hover:bg-accent">
                            <Bell className="h-5 w-5" />
                            <span className="absolute top-1 right-1 w-2 h-2 bg-destructive rounded-full" />
                        </button>
                    </div> */}
                    <a
                        href="/login"
                        className="px-4 py-2 rounded-lg font-semibold bg-gray-100 hover:bg-gray-200 text-sm transition-colors"
                    >
                        Log in
                    </a>
                    <a
                        href="/signup"
                        className="px-4 py-2 rounded-lg font-semibold bg-[#6366f1] hover:bg-[#5558e3] text-white text-sm transition-colors"
                    >
                        Sign up
                    </a>
                </div>
            </div>
        </header>
    );
};

export default Navbar;
