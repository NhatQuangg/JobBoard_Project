import React from "react";

interface PasswordCriteriaProps {
    password: string;
}

const PasswordCriteria: React.FC<PasswordCriteriaProps> = ({ password }) => {
    const passwordMinLength = password.length >= 8;
    const passwordHasUpper = /[A-Z]/.test(password);
    const passwordHasLower = /[a-z]/.test(password);
    const passwordHasNumber = /[0-9]/.test(password);

    return (
        <ul className="mt-1 ml-3 text-sm text-gray-600 space-y-1">
            <li
                className={
                    passwordMinLength ? "text-green-600" : "text-gray-400"
                }
            >
                {passwordMinLength ? "✓" : "○"} At least 8 characters
            </li>
            <li
                className={
                    passwordHasUpper ? "text-green-600" : "text-gray-400"
                }
            >
                {passwordHasUpper ? "✓" : "○"} At least 1 uppercase letter
            </li>
            <li
                className={
                    passwordHasLower ? "text-green-600" : "text-gray-400"
                }
            >
                {passwordHasLower ? "✓" : "○"} At least 1 lowercase letter
            </li>
            <li
                className={
                    passwordHasNumber ? "text-green-600" : "text-gray-400"
                }
            >
                {passwordHasNumber ? "✓" : "○"} At least 1 number
            </li>
        </ul>
    );
};

export default PasswordCriteria;
