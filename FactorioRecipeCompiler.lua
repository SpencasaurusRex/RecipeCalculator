file = io.open("recipes.csv", "w")
io.output(file);

data = {}
data["extend"] = function (data, t)
	for n, recipe in ipairs(t) do
		energy = recipe["energy_required"]
		if energy == nil then
			energy = .5
		end
		io.write(recipe["name"] .. ',energy,'..energy..'\n')
		for i, component in ipairs(recipe["ingredients"]) do
			cname = component[1] or component["name"]
			camt = component[2] or component["amount"]
			io.write(recipe["name"] .. ',' .. cname .. ',' .. camt, '\n')
        end
    end
end

files = {
    "ammo",
    "capsule",
    "demo-furnace-recipe",
    "demo-recipe",
    "demo-turret",
    "equipment",
    "fluid-recipe",
    "furnace-recipe",
    "inserter",
    "module",
    "recipe",
    "turret",
}

for i, f in ipairs(files) do
	dofile("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Factorio\\data\\base\\prototypes\\recipe\\" .. f .. ".lua")
end

io.close(file)
