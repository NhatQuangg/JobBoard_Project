import React from "react";

interface InputFieldProps {
    id: string;
    label: string;
    type?: string;
    placeholder?: string;
    value: string;
    onChange: (e: React.ChangeEvent<HTMLInputElement>) => void;
    required?: boolean;
}

const InputField = ({
    id,
    label,
    type = "text",
    placeholder,
    value,
    onChange,
    required = false,
}: InputFieldProps) => (
    <div className="space-y-1">
        <label htmlFor={id} className="text-sm text-gray-900">
            {label}
        </label>
        <input
            id={id}
            type={type}
            placeholder={placeholder}
            value={value}
            onChange={onChange}
            required={required}
            className="h-12 w-full px-3 border border-gray-300 rounded-lg focus:border-purple-500 focus:ring-1 focus:ring-purple-500"
        />
    </div>
);

export default InputField;
