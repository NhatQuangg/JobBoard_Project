import React from "react";
import { Link } from "react-router-dom";
import logo from "../Logo/logo.png";

interface AuthHeaderProps {
    title: string;
}

const AuthHeader = ({ title }: AuthHeaderProps) => (
    <div className="space-y-2">
        <div className="flex justify-center">
            <Link to="/">
                <img
                    src={logo}
                    alt="Logo"
                    className="w-12 h-12 object-contain cursor-pointer hover:opacity-80 transition"
                />
            </Link>
        </div>
        <h1 className="text-3xl font-semibold text-gray-900 text-center">
            {title}
        </h1>
    </div>
);

export default AuthHeader;
